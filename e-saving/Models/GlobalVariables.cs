namespace variables.Models
{
    public class GlobalVariables // aqui é declarado a classe
    {
        public string userLogged {get; set;}
        public string isCliente {get; set;}
        public string isParceiro {get; set;}
        public string isComprador {get; set;}
        public string nome {get; set;}
    }

    public static class RepositorioGlobalVariables
    {

        public static GlobalVariables Variables = new GlobalVariables {
            userLogged = "false",
            isCliente = "false",  // aqui é criado um novo objeto
            isParceiro = "false",
            isComprador = "false",
            nome = "default"
        };
        
        public static string SwitchUserLogged()
        {
            var variable = Variables;

            if (variable.userLogged == "false") {
                variable.userLogged = "true";
            } else {
                variable.userLogged = "false";
                variable.isCliente = "false";
                variable.isParceiro = "false";
                variable.isComprador = "false";
            }

            return variable.userLogged;
        }


    }
}