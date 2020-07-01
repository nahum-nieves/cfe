using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MedicionesService.Autenticacion
{
    public class ValidadorUsuarios : MembershipProvider
    {
        //        public override string ApplicationName { get; set; }
        public override string ApplicationName{
            get{
                throw new NotImplementedException("No se implementó el método en el membership personalizado");
            }set{
                throw new NotImplementedException("No se implementó el método en el membership personalizado");
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override bool EnablePasswordReset
        {
            get { return false; }
        }

        public override bool EnablePasswordRetrieval
        {
            get { return false; }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override int MinRequiredPasswordLength
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override bool RequiresUniqueEmail
        {
            get { throw new NotImplementedException("No se implementó el método en el membership personalizado"); }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException("No se implementó el método en el membership personalizado");
        }

        public bool verificaUsuario(string username, string password) {

            return (true);

            //si existe, regresar true

            //si no existe, regresar false
            
        }


        public override bool ValidateUser(string username, string password)
        {
            bool resp = verificaUsuario(username, password);
            if (resp) return true;
            else {
                return false; 
            }
        }
    }
}