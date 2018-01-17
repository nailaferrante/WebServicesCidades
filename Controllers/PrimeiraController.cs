using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebServicesCidades.Models;

namespace WebServicesCidades.Controllers
{
    //Vamos definir a rota para a requisição do serviço
    [Route("api/[controller]")] // a rota é no caso ap / nome do controller
    public class PrimeiraController:Controller
    {
        /* [HttpGet]// exibe o dado 
        public IEnumerable<string> Get(){ // índice que navega entro da lista ou array, ele intera o array como se fosse um foreach
             return new string[]{
                 "Curitiba","Porto Alegre","Salvador","Belo Horizonte"
             };*/

        /* [HttpGet("{id}")]//id é o parâmetro
        public string Get(int id){
            return new string[]{
                "Curitiba","Porto Alegre","Salvador","Belo Horizonte"
            }[id]; */
        
        Cidades cidade = new Cidades();       

        [HttpGet]
        public IEnumerable<Cidades> Get(){
            return cidade.Listar();
        }    
    }
}