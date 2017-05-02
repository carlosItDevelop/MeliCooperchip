
namespace Models
{
    /// <summary>
    /// Ainda não foi utilizada estas classes e enum;
    /// </summary>
    public class Enumeracoes
    {
        public enum Tag
        {
            delivered,
            not_delivered,
            paid,
            not_paid
        }

        public enum OrderStatus
        {
            confirmed,
            payment_required,
            payment_in_process,
            paid,
            cancelled
        }

        public enum shipping_status { 
            pending,
            handling, // Preparando
            shipped,  // Enviado
            delivered,  // Entregue
            not_delivered, // Não Entregue
            cancelled,
            not_verified // Não Verificado
        }
    }
}
