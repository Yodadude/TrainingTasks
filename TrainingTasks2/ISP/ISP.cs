using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks2.ISP
{

	public interface IAnimalBase
	{
		void See();
		void Eat();
	}

	public interface IAnimalFlight
	{
		void Fly();
	}

    public interface IAnimalRunner
    {
        void Run();
    }
}
