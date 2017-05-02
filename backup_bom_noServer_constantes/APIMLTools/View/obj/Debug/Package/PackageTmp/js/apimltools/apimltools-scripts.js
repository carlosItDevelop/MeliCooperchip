/*
    Conjunto de functions personalizadas escritas especificamente para o projeto APIMLTools.
    Por: Carlos Alberto dos Santos
    Criada em:     05/05/2015
    Atualizada em: 05/05/2015
*/

function AdicionaRotaDeFrete() {
    var campo = document.getElementById("txtRotaFrete");
    document.getElementById("txtResposta").value += "\n--------------- \nRota de Frete: \n---------------\n" + campo.value;
    LimpaRotaFrete();
}

function LimpaRotaFrete() {
    document.getElementById("txtRotaFrete").value = "";
}


function MostraFrete() {
    PageMethods.getDetalhesFrete(ChamarMetodoSucesso, ChamarMetodoErro);
  }
function ChamarMetodoSucesso(result, userContext, getDetalhesFrete) {
   alert(result);
  }
function ChamarMetodoErro(error, userContext, getDetalhesFrete) {
   alert(error.get_message());
  }

