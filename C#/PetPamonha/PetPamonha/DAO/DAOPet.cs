﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetPamonha.DAO;
using PetPamonha.Classes_com_Properties;

namespace PetPamonha
{
    class DAOPet
    {
        private MySqlConnection con;
        private Formatador formatar;

        public DAOPet()
        {
            this.con = new Conexao().Con;
            this.formatar = new Formatador();
        }
        
        public void inserePet(Pet pet)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into pet (nome,dataDeNascimento,rga,raca,idCliente) values(@nome,@dataDeNascimento,@rga,@raca,@idCliente)";
                cmd.Parameters.AddWithValue("@nome", pet.Nome);
                pet.DataDeNascimento = formatar.formatarData(pet.DataDeNascimento);
                cmd.Parameters.AddWithValue("@dataDeNascimento", pet.DataDeNascimento);
                cmd.Parameters.AddWithValue("@rga", pet.RGA);
                cmd.Parameters.AddWithValue("@raca", pet.Raca);
                cmd.Parameters.AddWithValue("@idCliente", pet.Dono);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
        }

        public void removePet(Pet pet)
        {
        }

        public List<Pet> getListPets()
        {
            MySqlDataReader leitor;
            List<Pet> pets = null;
            try
            {
                this.con.Open();
                pets = new List<Pet>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from pet";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Pet p = new Pet();
                    p.IdPet = (int)leitor["idPet"];
                    p.Nome = (String)leitor["nome"];
                    p.DataDeNascimento = Convert.ToString(leitor["dataDeNascimento"]);
                    p.DataDeNascimento = formatar.removerHora(p.DataDeNascimento);
                    p.Raca = (String)leitor["raca"];
                    p.RGA = (String)leitor["rga"];
                    pets.Add(p);
                }
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
            return pets;
        }

        public Pet localizar(int id){
            MySqlDataReader leitor;
            Pet pet = null;
            try
            {
                this.con.Open();
                pet= new Pet();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from pet where idPet = '"+id+"'";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    pet.IdPet = Convert.ToInt32(id);
                    pet.Nome = (String)leitor["nome"];
                    pet.DataDeNascimento = Convert.ToString(leitor["dataDeNascimento"]);
                    pet.DataDeNascimento = formatar.removerHora(pet.DataDeNascimento);
                    pet.Raca = (String)leitor["raca"];
                    pet.RGA = (String)leitor["rga"];
                    pet.Dono= Convert.ToInt32(leitor["idCliente"]);
                }
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
            return pet;
        }

        public Pet localizar(String RGA)
        {
            MySqlDataReader leitor;
            Pet pet = null;
            try
            {
                this.con.Open();
                pet = new Pet();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from pet where RGA = '" + RGA + "'";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    pet.IdPet = Convert.ToInt32(leitor["idPet"]);
                    pet.Nome = (String)leitor["nome"];
                    pet.DataDeNascimento = Convert.ToString(leitor["dataDeNascimento"]);
                    pet.DataDeNascimento = formatar.removerHora(pet.DataDeNascimento);
                    pet.Raca = (String)leitor["raca"];
                    pet.RGA = (String)leitor["rga"];
                    pet.Dono = Convert.ToInt32(leitor["idCliente"]);
                }
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
            return pet;
        }

    }
}
