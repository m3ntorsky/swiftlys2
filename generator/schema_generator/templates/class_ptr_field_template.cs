  public $INTERFACE_TYPE$? $NAME$ {
    get {
      var ptr = _Handle.Read<nint>(Schema.GetOffset($HASH$));
      return ptr.IsValidPtr() ? new $IMPL_TYPE$(ptr) : null;
    }
  }