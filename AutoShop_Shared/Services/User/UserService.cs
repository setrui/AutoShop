using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop_Shared.Models;
using Newtonsoft.Json;


namespace AutoShop_Shared.Services
{
    public  class UserService : IUserService
    {
        private  readonly IRepository<User> _repository;

        //Constructeur avec l'injection de la dependance en parametre
        public UserService(IRepository<User> repo)
        {
            //Ma variable privée = instance de k'injection de dépendance
            _repository = repo;
        }

        /// <summary>
        /// retourne tout les utilisateurs
        /// </summary>
        /// <returns></returns>
       public  List<User> GetUsers()
        {
            //Ouvrir le fichier
            //Lire le fichier
            List<User> users = _repository.GetItems(@"C:\Users\campus\Source\Repos\AutoShop\AutoShop_Web\Files\users.json");            //retoutner le resultat
            return users;
        }

        /// <summary>
        /// retourne les utilisateurs filtrés par Level
        /// </summary>
        /// <param name="level">Level de l'utilisateur</param>
        /// <returns></returns>
        public  List<User> GetUsers(byte level)
        {
            //recuperer tout les users
            List<User> users = GetUsers();
            //filtre les users
            users = users.Where(q=>q.Level >= level).ToList();
            //renvoie le resultat
            return users;
            //enlever l'exception
        }
        
        /// <summary>
        /// récuppération d'un user par son id
        /// </summary>
        /// <param name="id">représente l'Id de l'utilisateur, de type GUID</param>
        /// <returns>Retourne un objet User ou un Null si l'id n'est pas attribué</returns>
        public  User GetUser(string id)
        {
            User user = GetUsers().Single(q => q.Id == id);
            return user;
        }
    }
}
