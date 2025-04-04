using CountryStateManager.BussinessLayer.Models;
using CountryStateManager.BussinessLayer.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateManager.BussinessLayer.Interface
{
    public interface IStateRepository
    {
        public int Create(State state);
        public int Update(StateViewModel state);
        public List<State> List();
        public StateViewModel GetById(int id);
        public int Delete(int id);
        public int ActivatState(int id, bool flag);
    }
}
