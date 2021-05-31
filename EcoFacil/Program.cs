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
			//Novo tipo de resíduo
			var novoTipoResiduo = new TipoResiduo(1, "Hospitalar", true);

			//Novos tipos de usuários
			var novoTipoUsuarioEmpresa = new TipoUsuario(1, TiposDeUsuarios.Empresa);
			var novoTipoUsuarioEmpresaGerenciamentoResiduos = new TipoUsuario(1, TiposDeUsuarios.EmpresaGerenciamentoDeResiduos);

			//Novos usuarios
			var novaEmpresaGerenciamentoResiduos = new EmpresaGerenciamentoResiduos(1, "Sempre Verde Soluções Ambientais", "sempreverdesolamb@gmail.com", "verde4545", novoTipoUsuarioEmpresa);
			var novoUsuario = new UsuarioSistema(1, "Hospital Nova Saúde", "novasaude1212@gmail.com", "senha1212", novoTipoUsuarioEmpresaGerenciamentoResiduos);

			//Novo serviço
			var novoServicoOferecido = new ServicoOferecidoEmpresaGerenciamentoResiduos(1, "Incineração de lixo hospitalar", true, novaEmpresaGerenciamentoResiduos);

			//Novo orçamento
			var novoOrcamentoSolitado = new OrcamentoSolicitado(1, 150, DateTime.Now, novaEmpresaGerenciamentoResiduos, novoTipoResiduo, novoUsuario);

			Console.WriteLine("Informações da empresa(cliente): ");
			Console.WriteLine("Nome: " + novoUsuario.Nome);
			Console.WriteLine("Email: " + novoUsuario.Email);
			Console.WriteLine("Tipo de usuário: " + Enum.GetName(typeof(TiposDeUsuarios), novoUsuario.TipoUsuario.TipoDeUsuario));
			Console.WriteLine("Senha (criptografada): " + novoUsuario.Senha);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informações da empresa de gerenciamento de resíduos: ");
			Console.WriteLine("Nome: " + novaEmpresaGerenciamentoResiduos.Nome);
			Console.WriteLine("Email: " + novaEmpresaGerenciamentoResiduos.Email);
			Console.WriteLine("Tipo de usuário: " + Enum.GetName(typeof(TiposDeUsuarios), novaEmpresaGerenciamentoResiduos.TipoUsuario.TipoDeUsuario));
			Console.WriteLine("Senha: (criptografada)" + novaEmpresaGerenciamentoResiduos.Senha);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informações do serviço oferecido pela " + novoServicoOferecido.EmpresaGerenciamentoResiduos.Nome + ":");
			Console.WriteLine("Serviço: " + novoServicoOferecido.NomeServico);
			Console.WriteLine(String.Format("Faz a coleta: {0}", novoServicoOferecido.FazColeta ? "Sim" : "Não"));
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Informações do orçamento solicitado pela empresa " + novoOrcamentoSolitado.Usuario.Nome + " para a empresa de gerenciamento de resíduos " + novoOrcamentoSolitado.EmpresaGerenciamentoResiduos.Nome + ":");
			Console.WriteLine("Quantidade de resíduos: " + novoOrcamentoSolitado.QuantidadeResiduos + "Kg");
			Console.WriteLine("Data da solicitação: " + novoOrcamentoSolitado.DataSolicitacao.ToString());
			Console.WriteLine("Tipo de resíduo:" + novoOrcamentoSolitado.TipoResiduo.NomeTipoResiduo);
			Console.WriteLine(String.Format("É perigoso: {0}", novoOrcamentoSolitado.TipoResiduo.Perigoso ? "Sim" : "Não"));
		}
	}
}
