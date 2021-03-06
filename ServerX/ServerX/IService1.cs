﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace ServerX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // ******** MY FUNCTIONS (CUSTOM ADDED) ******** \\

        // ******** USERDL FUNCTIONS ******** \\

        [OperationContract]
        void addUser(string name, string email, string password, string phone);

        [OperationContract]
        User getUserBYEmail(string email);


        [OperationContract]
        recipe getRecipeAT(string index);

        [OperationContract]
        User getUserBYUsername(string username);

        [OperationContract]
        List<User> getAllUsers();

        [OperationContract]
        int getUsersCount();

        [OperationContract]
        void addRecipe(string title, string author, string date, string url, string desc, List<string> categories);

        [OperationContract]
        List<recipe> getRecipes();

        [OperationContract]
        int getRecipeCount();

        [OperationContract]
        void addCategory(string c_name);

        [OperationContract]
        List<category> getAllCategories();

        [OperationContract]
        void deleteRecipe(string index);

        [OperationContract]
        void generateDietPlan(User user);

        [OperationContract]
        void deleteUser(string index);

        [OperationContract]
        void deleteCategory(string index);

        [OperationContract]
        void updateCategory(string index, string categoryName);

        [OperationContract]
        void updateUser(string index, string name, string email, string password, string phone);

        [OperationContract]
        recipe getRandomRecipe();

        [OperationContract]
        void updateRecipe(string index, string title, string author, string date, string url, string desc, List<string> categories);

        // ******** USERDL FUNCTIONS ******** \\
        // ******** MY FUNCTIONS (CUSTOM ADDED):: END ******** \\
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
