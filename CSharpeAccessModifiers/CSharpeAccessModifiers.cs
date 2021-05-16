using StoreOfFunctionToAccess;

namespace CSharpeAccessModifiers
{
    class CSharpeAccessModifiers : StoreOfFunctions
    {
        public static void Main() { }

        private void AccessingMethods()
        {
            PublicMethod(); // Access Modifier is Public : So I can access it here!!
            
            //PrivateMethod(); // Access Modifier is PRIVATE : So I CANNOT ACCESS it here!!
            
            //InternalMethod(); // Access Modifier is INTERNAL : So I CANNOT ACCESS it here!!
            
            ProtectedInternalMethod(); // Access Modifier is PROTECT INTERNAL : We have implemeted <StoreOfFunctions> and it is internal so that I can access it from here
            
            ProtecedMethod();  // Access Modifier is PROTECT : We have implemeted <StoreOfFunctions> and it is accessible here and it is also accessbile in <StoreOfFunctionsToAccess> assembly to all methods even though they have NOT implemented <StoreOfFunctions>
            
            //PrivateProtecedMethod(); // Access Modifier is Private Protected : 
        }
    }
}
