using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Examples_Alura_POO.Entities
{
    class Client
    {
        private string _cpf;
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Cpf 
        {
            get 
            {
                return _cpf;
            }
            set
            {
                // If in future have a logical of validation
                _cpf = value;
            } 
        }



    }
}
