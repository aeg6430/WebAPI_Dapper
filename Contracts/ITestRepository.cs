

namespace WebAPI.Contracts
{
    public interface ITestRepository
    {
        public Task<IEnumerable<Test>>Get();
    }
}
