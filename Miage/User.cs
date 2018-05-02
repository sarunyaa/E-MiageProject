using System;
namespace Miage
{
    public abstract class User
    {
        private String id;
        private String idConnexion;
        private String role;
        private String firstName;
        private String name;
        private Boolean statutConnexion;
        private DateTime dateLastConnexion;
        private DateTime timeLastConnexion;
        private String mailAdress;
        private String phoneNumber;
        private FileStyleUriParser profilePicture;

        public User()
        {
        }
        public Boolean Connect()
        {
            return true;
        }
        public Boolean Disconnect()
        {
            return true;
        }
        public String modifyMailAdress(String mail)
        {
            return mail;
        }
        public String modifyPhoneNumber(String number)
        {
            return number;
        }
        public FileStyleUriParser modifyProfilePicture(FileStyleUriParser image)
        {
            return image;
        }
    }
}
