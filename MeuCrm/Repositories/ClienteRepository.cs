using Dapper;
using MeuCrm.Connections;
using MeuCrm.DTOs;
using MeuCrm.Models;
using MeuCrm.Repositories.IRepositories;
using System;

namespace MeuCrm.Repositories
{
    public class ClienteRepository : ConnectionMySql, IClienteRepository
    {
        public PaginatedResponse<Cliente> GetClientes(int page, int pageSize)
        {
            var response = new PaginatedResponse<Cliente>();

            var query = "SELECT * FROM TB_CLIENTE";
            var totalCount = Connection.QuerySingle<int>($"SELECT COUNT(*) FROM ({query}) AS Total");
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            if (page < 1)
                page = 1;
            if (page > totalPages)
                page = totalPages;

            var offset = (page - 1) * pageSize;
            var clientes = Connection.Query<Cliente>($"{query} LIMIT {offset}, {pageSize}");

            response.Items = clientes;
            response.TotalItems = totalCount;
            response.TotalPages = totalPages;
            response.CurrentPage = page;
            response.FirstPage = page == 1;
            response.LastPage = page == totalPages;

            return response;
        }
    }
}

