using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Spectre.Console;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;

namespace SwiftlyS2.Core.Hooks;

internal class HookManager {

  private class HookNode {
    public required Guid Id { get; init; }

    public nint HookHandle { get; set; }
    public nint OriginalFuncPtr { get; set; }
    public required Func<Func<nint>, Delegate> CallbackBuilder { get; init; }
    public Delegate? BuiltDelegate { get; set; }
    public nint BuiltPointer { get; set; }
  }

  private class HookChain {
    public bool Hooked { get; set; } = false;
    public required nint FunctionAddress { get; set; }
    public nint HookHandle { get; set; }
    public List<HookNode> Nodes { get; } = new();
  }

  private readonly object _sync = new();
  private readonly Dictionary<nint, HookChain> _chains = new();

  public Guid AddHook(nint functionAddress, Func<Func<nint>, Delegate> callbackBuilder) {
    HookChain chain;
    HookNode node = new HookNode {
      Id = Guid.NewGuid(),
      CallbackBuilder = callbackBuilder,
    };

    lock (_sync) {
      if (!_chains.TryGetValue(functionAddress, out chain)) {
        chain = new HookChain { FunctionAddress = functionAddress };
        _chains[functionAddress] = chain;
      }
      chain.Nodes.Add(node);
      RebuildChain(chain);
    }

    return node.Id;
  }

  public void Remove(List<Guid> nodeIds) {
    lock (_sync) {
      var chains = _chains.Values.Where(c => c.Nodes.Any(n => nodeIds.Contains(n.Id))).ToList();
      if (chains.Count == 0) return;
      foreach (var chain in chains) {
        chain.Nodes.RemoveAll(n => nodeIds.Contains(n.Id));
        RebuildChain(chain);
      }
    }
  }

  private void RebuildChain(HookChain chain) {
    try {
      // Rebuild delegates from first to last, wiring each to previous pointer (or original for first)
      foreach (var node in chain.Nodes) {
        node.BuiltDelegate = null;
        node.BuiltPointer = nint.Zero;
      }

      if (chain.Hooked) {
        for (int i = 0; i < chain.Nodes.Count; i++) {
          chain.Nodes[i].BuiltDelegate = null;
          chain.Nodes[i].BuiltPointer = nint.Zero;
          if (chain.Nodes[i].HookHandle != 0) {
            NativeHooks.DeallocateHook(chain.Nodes[i].HookHandle);
            chain.Nodes[i].HookHandle = 0;
          }
        }
        NativeHooks.DeallocateHook(chain.HookHandle);
        chain.HookHandle = 0;
        chain.Hooked = false;
      }
      chain.HookHandle = NativeHooks.AllocateHook();

      for (int i = 0; i < chain.Nodes.Count; i++) {
        var node = chain.Nodes[i];

        var built = node.CallbackBuilder.Invoke(() => node.OriginalFuncPtr);
        node.BuiltDelegate = built;
        node.BuiltPointer = Marshal.GetFunctionPointerForDelegate(node.BuiltDelegate);
        if (i == 0)
        {
          NativeHooks.SetHook(chain.HookHandle, chain.FunctionAddress, node.BuiltPointer);
          node.OriginalFuncPtr = NativeHooks.GetHookOriginal(chain.HookHandle);
          NativeHooks.EnableHook(chain.HookHandle);
          chain.Hooked = true;
        } else {
          node.HookHandle = NativeHooks.AllocateHook();
          NativeHooks.SetHook(node.HookHandle, chain.Nodes[i - 1].OriginalFuncPtr, node.BuiltPointer);
          NativeHooks.EnableHook(node.HookHandle);
          node.OriginalFuncPtr = NativeHooks.GetHookOriginal(node.HookHandle);
        }
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }
} 