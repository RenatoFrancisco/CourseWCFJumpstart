﻿using System.Collections.Generic;
using System.ServiceModel;

namespace ZzaApp.Services
{
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
