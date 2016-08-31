
namespace Nop.Core.Infrastructure
{
    public class EngineContext
    {
        public static void Initialize()
        {
            NopEngine nopEngine = new NopEngine();
            nopEngine.Initialize();
        }
    }
}
