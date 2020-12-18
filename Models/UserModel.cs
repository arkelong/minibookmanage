using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class UserModel
    {
        private int uid;
        private string username;
        private string gender;
        private int borrowNum;
        private string psd;
        private int level;

        public UserModel(int level)
        {
            this.level = level;
        }

        public int Uid { get { return uid; } }
        public string Username { get => username; }
        public string Gender { get => gender; }
        public int BorrowNum { get => borrowNum; }
        public int Level { get => level; }

        public UserModel()
        {
        }

        public UserModel(int uid, string username, string gender, int borrowNum, string psd, int level)
        {
            this.uid = uid;
            this.username = username;
            this.gender = gender;
            this.borrowNum = borrowNum;
            this.psd = psd;
            this.level = level;
        }

        public UserModel(string username, string gender, int borrowNum, string psd, int level)
        {
            this.username = username;
            this.gender = gender;
            this.borrowNum = borrowNum;
            this.psd = psd;
            this.level = level;
        }




    }
}
