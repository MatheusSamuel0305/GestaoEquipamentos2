using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program {
    static List<Equipamento> equipamentos = new List<Equipamento>();
    static List<TipoEquipamento> tiposEquipamento = new List<TipoEquipamento>();
    static List<Fabricante> fabricantes = new List<Fabricante>();
    static List<Funcionario> funcionarios = new List<Funcionario>();
    static List<Cliente> clientes = new List<Cliente>();

    static void Main() {
        Autenticar();
        MenuPrincipal();
    }

    static void Autenticar() {
        while (true) {
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            if (login == "admin" && senha == "1234")
                break;
        }
    }

    static void MenuPrincipal() {
        int opcao;
        do {
            Console.WriteLine("\n1. Equipamentos\n2. Tipos de Equipamentos\n3. Fabricantes\n4. Funcionários\n5. Clientes\n6. Importar/Exportar CSV\n7. Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1: MenuEquipamentos(); break;
                case 2: MenuTiposEquipamento(); break;
                case 3: MenuFabricantes(); break;
                case 4: MenuFuncionarios(); break;
                case 5: MenuClientes(); break;
                case 6: MenuCSV(); break;
            }
        } while (opcao != 7);
    }

    static void MenuEquipamentos() {
        Console.WriteLine("\n1. Adicionar\n2. Visualizar\n3. Editar\n4. Excluir");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao) {
            case 1: AdicionarEquipamento(); break;
            case 2: VisualizarEquipamentos(); break;
            case 3: EditarEquipamento(); break;
            case 4: ExcluirEquipamento(); break;
        }
    }

    static void AdicionarEquipamento() {
        Equipamento eq = new Equipamento();
        eq.Numero = equipamentos.Count + 1;
        Console.Write("Nome: ");
        eq.Nome = Console.ReadLine();
        Console.Write("Número de Série: ");
        eq.NumeroSerie = Console.ReadLine();
        Console.Write("Preço: ");
        eq.Preco = decimal.Parse(Console.ReadLine());
        Console.Write("Data Fabricação: ");
        eq.DataFabricacao = DateTime.Parse(Console.ReadLine());
        equipamentos.Add(eq);
    }

    static void VisualizarEquipamentos() {
        foreach (var eq in equipamentos) {
            Console.WriteLine($"Número: {eq.Numero}, Nome: {eq.Nome}, Preço: {eq.Preco}");
        }
    }

    static void EditarEquipamento() { /* Implementação semelhante à Adicionar */ }
    static void ExcluirEquipamento() { /* Implementação semelhante à Adicionar */ }

    static void MenuTiposEquipamento() { /* CRUD similar */ }
    static void MenuFabricantes() { /* CRUD similar */ }
    static void MenuFuncionarios() { /* CRUD similar */ }
    static void MenuClientes() { /* CRUD similar */ }

    static void MenuCSV() {
        Console.WriteLine("1. Importar CSV\n2. Exportar CSV");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao == 1) ImportarCSV();
        else ExportarCSV();
    }

    static void ImportarCSV() { /* Implementação CSV */ }
    static void ExportarCSV() { /* Implementação CSV */ }
}

class Equipamento {
    public int Numero { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string NumeroSerie { get; set; }
    public DateTime DataFabricacao { get; set; }
}

class TipoEquipamento {
    public string Nome { get; set; }
    public string Descricao { get; set; }
}

class Fabricante {
    public string Nome { get; set; }
    public string Contato { get; set; }
}

class Funcionario {
    public string Nome { get; set; }
    public string Funcao { get; set; }
}

class Cliente {
    public string Nome { get; set; }
    public string CnpjCpf { get; set; }
}
