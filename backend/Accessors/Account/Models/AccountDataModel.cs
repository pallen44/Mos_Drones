using Accessors.Address.Models;

namespace Accessors.Account.Models;

    public class AccountDataModel
    {
        public int? AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AddressDataModel AccountAddress { get; set; }
        public bool IsAdmin { get; set; }

        public AccountDataModel()
        {
            AccountId = null;
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            AccountAddress = new AddressDataModel();
            IsAdmin = false;
        }
        public AccountDataModel(int? accountId, string firstName, string lastName, string email, string password, AddressDataModel accountAddress, bool isAdmin)
        {
            this.AccountId = accountId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.AccountAddress = accountAddress;
            this.IsAdmin = isAdmin;
        }
    }

    //     public override bool Equals(object obj)
    //     {
    //         if (obj == null || GetType() != obj.GetType())
    //             return false;
    //
    //         AccountDataModel other = (AccountDataModel)obj;
    //         return (AccountId == other.AccountId && FirstName == other.FirstName && LastName == other.LastName
    //                 && Email == other.Email && Password == other.Password && AccountAddress.Equals(other.AccountAddress)
    //                 && IsAdmin == other.IsAdmin);
    // }
