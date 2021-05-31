using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Novo tipo de res�duo
			var novoTipoResiduo = new TipoResiduo(1, "Hospitalar", true);

			//Novos tipos de usu�rios
			var novoTipoUsuarioEmpresa = new TipoUsuario(1, TiposDeUsuarios.Empresa);
			var novoTipoUsuarioEmpresaGerenciamentoResiduos = new TipoUsuario(1, TiposDeUsuarios.EmpresaGerenciamentoDeResiduos);

			//Novos usuarios
			var novaEmpresaGerenciamentoResiduos = new EmpresaGerenciamentoResiduos(1, "Sempre Verde Solu��es Ambientais", "sempreverdesolamb@gmail.com", "verde4545", novoTipoUsuarioEmpresa);
			var novoUsuario = new UsuarioSistema(1, "Hospital Nova Sa�de", "novasaude1212@gmail.com", "senha1212", novoTipoUsuarioEmpresaGerenciamentoResiduos);

			//Novo servi�o
			var novoServicoOferecido = new ServicoOferecidoEmpresaGerenciamentoResiduos(1, "Incinera��o de lixo hospitalar", true, novaEmpresaGerenciamentoResiduos);

			//Novo or�amento
			var novoOrcamentoSolitado = new OrcamentoSolicitado(1, 150, DateTime.Now, novaEmpresaGerenciamentoResiduos, novoTipoResiduo, novoUsuario);

			Console.WriteLine("Informa��es da empresa(cliente): ");
			Console.WriteLine("Nome: " + novoUsuario.Nome);
			Console.WriteLine("Email: " + novoUsuario.Email);
			Console.WriteLine("Tipo de usu�rio: " + Enum.GetName(typeof(TiposDeUsuarios), novoUsuario.TipoUsuario.TipoDeUsuario));
			Console.WriteLine("Senha (criptografada): " + novoUsuario.Senha);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informa��es da empresa de gerenciamento de res�duos: ");
			Console.WriteLine("Nome: " + novaEmpresaGerenciamentoResiduos.Nome);
			Console.WriteLine("Email: " + novaEmpresaGerenciamentoResiduos.Email);
			Console.WriteLine("Tipo de usu�rio: " + Enum.GetName(typeof(TiposDeUsuarios), novaEmpresaGerenciamentoResiduos.TipoUsuario.TipoDeUsuario));
			Console.WriteLine("Senha: (criptografada)" + novaEmpresaGerenciamentoResiduos.Senha);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informa��es do servi�o oferecido pela " + novoServicoOferecido.EmpresaGerenciamentoResiduos.Nome + ":");
			Console.WriteLine("Servi�o: " + novoServicoOferecido.NomeServico);
			Console.WriteLine(String.Format("Faz a coleta: {0}", novoServicoOferecido.FazColeta ? "Sim" : "N�o"));
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informa��es do or�amento solicitado pela empresa " + novoOrcamentoSolitado.Usuario.Nome + " para a empresa de gerenciamento de res�duos " + novoOrcamentoSolitado.EmpresaGerenciamentoResiduos.Nome + ":");
			Console.WriteLine("Quantidade de res�duos: " + novoOrcamentoSolitado.QuantidadeResiduos + "Kg");
			Console.WriteLine("Data da solicita��o: " + novoOrcamentoSolitado.DataSolicitacao.ToString());
			Console.WriteLine("Tipo de res�duo:" + novoOrcamentoSolitado.TipoResiduo.NomeTipoResiduo);
			Console.WriteLine(String.Format("� perigoso: {0}", novoOrcamentoSolitado.TipoResiduo.Perigoso ? "Sim" : "N�o"));
		}
	}
}
