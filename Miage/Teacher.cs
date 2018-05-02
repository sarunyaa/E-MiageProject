using System;
namespace Miage
{
    public class Teacher : User
    {
        private int[] moduleAffected;
        public Teacher()
        {
        }
        public String SetProposition(String p)
        {
            return p;
        }
		public void ConsultMarkLearner() {}
		public void RecapExchangeLearner() {}
	}
}