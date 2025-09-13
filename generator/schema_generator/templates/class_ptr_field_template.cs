  public $INTERFACE_TYPE$ $NAME$ {
    get => new $IMPL_TYPE$(_Handle.Read<nint>(Schema.GetOffset($HASH$)));
  }