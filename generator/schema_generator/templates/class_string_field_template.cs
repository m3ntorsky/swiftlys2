  public string $NAME$ {
    get {
      var ptr = _Handle.Read<nint>(Schema.GetOffset($HASH$));
      return Schema.GetString(ptr);
    }
    set => Schema.SetString(_Handle, $HASH$, value);
  } 