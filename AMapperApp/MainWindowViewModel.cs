using AMapperCore.Users.Models;
using AMapperCore.Users.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AMapperApp
{
    public class MainWindowViewModel : ViewModelBase
    {


        private RelayCommand _testCmd;
        public RelayCommand TestCmd => _testCmd ?? (_testCmd = new RelayCommand(
            () => test(),
            () => { return 1 == 1; },
            keepTargetAlive: true
            ));
        private void test()
        {
            IUserService userService = new UserService();
            Guid guid1 = userService.AddUser("1", "Uno");
            Guid guid2 = userService.AddUser("2", "Due");
            IEnumerable < Guid > guids= userService.GetGuids();
            UserDTO userDTO1 = userService.GetUserDTO(guid1);
            UserDTO userDTO2 = userService.GetUserDTO("2","Due");


        }
    }
}
