using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class Usuario
	{
		public string Nome { get; protected set; }
		private string _email;
		public string Email
		{
			get
			{
				return this._email;
			}
			protected set
			{
				//Verifica se o e-mail é válido
				Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
				Match match = regex.Match(value);
				if (match.Success)
					_email = value;
				else
					throw new ArgumentException("E-mail incorreto");
			}
		}
		private string _senha;
		public string Senha
		{
			get
			{
				return this._senha;
			}
			protected set
			{
				_senha = Sha256Hash(value);
			}
		}


		//Criptografa a senha
		private string Sha256Hash(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}
