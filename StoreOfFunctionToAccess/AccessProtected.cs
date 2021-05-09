namespace StoreOfFunctionToAccess
{
    class AccessProtected : StoreOfFunctions
    {
        private void callProtectedMetod()
        {
            PublicMethod();
            //PrivateMethod(); // Not accessible. Even from the same Assembly
            InternalMethod();
            ProtectedInternalMethod();
            ProtecedMethod();
            PrivateProtecedMethod();
        }
    }
}