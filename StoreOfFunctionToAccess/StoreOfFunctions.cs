using System;

namespace StoreOfFunctionToAccess
{
    public class StoreOfFunctions
    {
        // Public - Access Modifiers - Everyone across all assembilies will be able to access <FreeAccessToAll> method
        public void PublicMethod()
        {
            Console.WriteLine("Public Access Modifiers --> PublicMethod = Accessible to All. Even to <CSharpeAccessModifiers> Assembly");
            Console.ReadLine();

            // Method <PrivateMethod> with Access Modifier as PRIVATE is accessible ONLY in Class <StoreOfFunctions>
            PrivateMethod();
        }

        // Private - Everyone Inside the class <StoreOfFunctions> will be able to access this Method
        private void PrivateMethod()
        {
            Console.WriteLine("Private Access Modifiers --> PrivateMethod = Only within the <StoreOfFunctions> can access me !!");
            Console.ReadLine();
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Proteced Access Modifiers --> InternalMethod = Everyone in Assembly <OnlyInAssemblyStoreOfFunctionToAccess> can access Me !!");
            Console.ReadLine();
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Proteced Internal Access Modifiers --> ProtectedInternalMethod = Implement me and then you will be able to access me in and outside Assembly !!");
            Console.ReadLine();
        }
        protected void ProtecedMethod()
        {
            Console.WriteLine("Proteced Access Modifiers --> ProtecedMethod = Only accessibly in <StoreOfFunctionToAccess> and also to the classes which are inheriting <StoreOfFunctions>.  !!");
            Console.ReadLine();
        }

        private protected void PrivateProtecedMethod()
        {
            Console.WriteLine("Private Proteced Access Modifiers --> PrivateProtecedMethod = Implement me and you will have access in same Assembly but you will not be able to access me from other assembly still YOU WILL NOT BE ABLE TO ACCESS ME  !!");
            Console.ReadLine();
        }
    }
}
