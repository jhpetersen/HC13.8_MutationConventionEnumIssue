namespace TestHC138bug
{
    public class Mutation {
    
        public Task<bool> TestMutation(
            string inputtext,
            TestEnum testEnum = TestEnum.Default
        ) {
            return Task.FromResult(testEnum == TestEnum.Default);
        }

    }
}