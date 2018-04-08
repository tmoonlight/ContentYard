using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace CY_System.Infrastructure
{
    public class SecurityPolicy
    {
        private HashCrypToGraphy m_hashObj;

        public static int checkEffectiveBitSize(string PwdValue)
        {
            int num2 = 0;
            int length = PwdValue.Length;
            double num4 = Math.Log(Math.Pow((double)getCharSetUsed(PwdValue), (double)length)) / Math.Log(2.0);
            if (num4 <= 32.0)
            {
                return 0;
            }
            if (num4 <= 64.0)
            {
                return 1;
            }
            if (num4 <= 128.0)
            {
                return 2;
            }
            if (num4 > 128.0)
            {
                num2 = 3;
            }
            return num2;
        }

        private static bool containsLowerCaseChars(string str)
        {
            Regex regex = new Regex("[a-z]");
            return regex.IsMatch(str);
        }

        private static bool containsNumbers(string str)
        {
            Regex regex = new Regex(@"[\d]");
            return regex.IsMatch(str);
        }

        private static bool containsPunctuation(string str)
        {
            Regex regex = new Regex(@"[\W|_]");
            return regex.IsMatch(str);
        }

        private static bool containsUpperCaseChars(string str)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.IsMatch(str);
        }

        public string EnPassWord(string PwdValue)
        {
            if (this.m_hashObj == null)
            {
                this.m_hashObj = new HashCrypToGraphy(HashProvider.SHA1);
            }
            return (this.m_hashObj.HashString(PwdValue) + "\x0003");
        }

        private static int getCharSetUsed(string pass)
        {
            int num = 0;
            if (containsNumbers(pass))
            {
                num += 10;
            }
            if (containsLowerCaseChars(pass))
            {
                num += 0x1a;
            }
            if (containsUpperCaseChars(pass))
            {
                num += 0x1a;
            }
            if (containsPunctuation(pass))
            {
                num += 0x1f;
            }
            return num;
        }
    }

    [ComVisible(true)]
    public class HashCrypToGraphy
    {
        private HashProvider _provider;
        private bool m_IsAddSalt;
        private short m_SaltLength;
        private string m_SaltValue;
        private HashAlgorithm mhash;

        public HashCrypToGraphy()
        {
            this._provider = HashProvider.SHA1;
            this.m_IsAddSalt = false;
            this.m_SaltValue = string.Empty;
            this.m_SaltLength = 8;
            this.mhash = this.SetHash();
        }

        public HashCrypToGraphy(HashProvider provider)
        {
            this._provider = provider;
            this.m_IsAddSalt = false;
            this.m_SaltValue = string.Empty;
            this.m_SaltLength = 8;
            this.mhash = this.SetHash();
        }

        public string CreateSalt()
        {
            byte[] data = new byte[8];
            new RNGCryptoServiceProvider().GetBytes(data);
            return Convert.ToBase64String(data);
        }

        public string HashString(string Value)
        {
            if (this.m_IsAddSalt)
            {
                if (this.m_SaltValue.Length == 0)
                {
                    this.m_SaltValue = this.CreateSalt();
                }
            }
            else
            {
                this.m_SaltValue = string.Empty;
            }
            byte[] bytes = Encoding.UTF8.GetBytes(Value + this.m_SaltValue);
            byte[] inArray = this.mhash.ComputeHash(bytes);
            this.mhash.Clear();
            return Convert.ToBase64String(inArray);
        }

        public void Reset()
        {
            this.m_SaltValue = string.Empty;
            this._provider = HashProvider.SHA1;
            this.m_IsAddSalt = false;
            this.m_SaltLength = 8;
            this.mhash = null;
        }

        private HashAlgorithm SetHash()
        {
            switch (this._provider)
            {
                case HashProvider.SHA1:
                    return new SHA1CryptoServiceProvider();

                case HashProvider.MD5:
                    return new MD5CryptoServiceProvider();

                case HashProvider.SHA256:
                    return new SHA256Managed();

                case HashProvider.SHA384:
                    return new SHA384Managed();

                case HashProvider.SHA512:
                    return new SHA512Managed();

                default:
                    return new SHA1CryptoServiceProvider();
            }
        }

        public bool IsAddSalt
        {
            get
            {
                return this.m_IsAddSalt;
            }
            set
            {
                this.m_IsAddSalt = value;
            }
        }

        public short SaltLength
        {
            get
            {
                return this.m_SaltLength;
            }
            set
            {
                this.m_SaltLength = value;
            }
        }

        public string SaltValue
        {
            get
            {
                return this.m_SaltValue;
            }
            set
            {
                this.m_SaltValue = value;
            }
        }
    }

    public enum HashProvider
    {
        MD5 = 2,
        SHA1 = 1,
        SHA256 = 4,
        SHA384 = 8,
        SHA512 = 0x10
    }
}

