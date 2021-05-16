namespace StoreOfFunctionToAccess
{
    public class AccessingPPII 
    {
        public void CallingPPII()
        {
            StoreOfFunctions storeOfFunctions = new StoreOfFunctions();
            
            storeOfFunctions.PublicMethod();
            
            // storeOfFunctions.PrivateMethod(); // Private method are not available beyond their declared boundaries. Not even in the same Assembly.
            
            storeOfFunctions.InternalMethod();
            
            storeOfFunctions.ProtectedInternalMethod();
            
            // storeOfFunctions.ProtecedMethod(); // Not available because we have not created an object of class which has implemented the StoreOfFunctions class and identifier is "Protected"
            
            // storeOfFunctions.PrivateProtecedMethod(); // Not available because we have not created an object of class which has implemented the StoreOfFunctions class and identifier is "Protected"
        }
    }
}
