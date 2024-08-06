using rACARS.Model.PhpVmsAPI;
using rACARS.Presentation.Extensions;
using rACARS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rACARS.Presentation.ViewModels
{
    class AcarsViewModel : ViewModelBase
    {
        #region Fields
        private PhpVmsTranslator phpVmsTranslator;
        private User user; 
        #endregion


        public AsyncRelayCommand GetBidsCommand { get; }

        #region Properties
        public User User { get { return user;  } set { user = value; UserFullName = user.name; } }
        public string UserFullName { get { return User.name; } set { User.name = value; NotifyPropertyChanged(); } }
        #endregion

        #region Constructors
        public AcarsViewModel()
        {
            User = new User();
            phpVmsTranslator = new PhpVmsTranslator();
            GetBidsCommand = new AsyncRelayCommand(GetBids);
        }
        public AcarsViewModel(User user) : this()
        {
            this.user = user;
            UserFullName = User.name;
        }
        #endregion

        

        private async Task<List<Bid>> GetBids()
        {
            return await phpVmsTranslator.GetBids(user);
        }
    }
}
