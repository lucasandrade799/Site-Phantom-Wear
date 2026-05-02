using System;
using System.Collections.Generic;
using System.Linq;

namespace PhantomWear
{
    // Modelo para o Usuário
    public class Usuario {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; } // "ADMIN" ou "CLIENTE"
    }

    // Modelo para o Produto
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }

    public class SistemaLoja {
        // Logins de teste já registrados
        public List<Usuario> Usuarios = new List<Usuario> {
            new Usuario { Email = "empresa@phantom.com", Senha = "123", Perfil = "ADMIN" },
            new Usuario { Email = "cliente@gmail.com", Senha = "123", Perfil = "CLIENTE" }
        };

        // Lista oficial de 10 produtos
        public List<Produto> Produtos = new List<Produto> {
            new Produto { Id = 1, Nome = "Camiseta Branca - Gorillaz", Preco = 89.90m, Estoque = 20 },
            new Produto { Id = 2, Nome = "Moletom Branco - Gojo", Preco = 189.90m, Estoque = 3 },
            new Produto { Id = 3, Nome = "Moletom Preto - Gemaplys", Preco = 199.90m, Estoque = 15 },
            new Produto { Id = 4, Nome = "Moletom Branco - Yunli", Preco = 179.90m, Estoque = 7 },
            new Produto { Id = 5, Nome = "Moletom Preto - Miles Morales", Preco = 210.00m, Estoque = 10 },
            new Produto { Id = 6, Nome = "Moletom Preto - Saiko", Preco = 195.00m, Estoque = 2 },
            new Produto { Id = 7, Nome = "Camiseta Preta - JF Classics", Preco = 109.90m, Estoque = 30 },
            new Produto { Id = 8, Nome = "Camiseta Branca - Choso", Preco = 99.90m, Estoque = 12 },
            new Produto { Id = 9, Nome = "Camiseta Preta - Toji", Preco = 119.90m, Estoque = 4 },
            new Produto { Id = 10, Nome = "Camiseta Branca - Korn", Preco = 89.90m, Estoque = 18 }
        };

        // Função para validar login
        public string FazerLogin(string email, string senha) {
            var user = Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            return user?.Perfil ?? "ERRO";
        }

        // Função para cadastrar novo cliente
        public void Cadastrar(string email, string senha) {
            Usuarios.Add(new Usuario { Email = email, Senha = senha, Perfil = "CLIENTE" });
        }
    }
}