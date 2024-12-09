namespace variables.Models
{
    public class GlobalVariables
    {
        public string userLogged {get; set;}
        public string isCliente {get; set;}
        public string isParceiro {get; set;}
        public string isComprador {get; set;}
    }

    public static class RepositorioGlobalVariables
    {

        public static GlobalVariables Variables = new GlobalVariables {
            userLogged = "false",
            isCliente = "false",
            isParceiro = "false",
            isComprador = "false"
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