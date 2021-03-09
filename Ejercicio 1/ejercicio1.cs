using System;

namespace Namespace {
    
    public static class Module {
        
        public class Cliente {
            
            public Cliente(object nombre) {
                this.nombre = nombre;
                this.monto = 0;
            }
            
            public virtual object depositar(object monto) {
                this.monto = this.monto + monto;
            }
            
            public virtual object extraer(object monto) {
                this.monto = this.monto - monto;
            }
            
            public virtual object retornar_monto() {
                return this.monto;
            }
            
            public virtual object imprimir() {
                Console.WriteLine(this.nombre, "tiene depositado la suma de", this.monto);
            }
        }
        
        public class Banco {
            
            public Banco() {
                this.cliente1 = Cliente("Adan");
                this.cliente2 = Cliente("Ashley");
                this.cliente3 = Cliente("Bretne");
            }
            
            public virtual object operar() {
                this.cliente1.depositar(100);
                this.cliente2.depositar(150);
                this.cliente3.depositar(200);
                this.cliente3.extraer(150);
            }
            
            public virtual object depositos_totales() {
                var total = this.cliente1.retornar_monto() + this.cliente2.retornar_monto() + this.cliente3.retornar_monto();
                Console.WriteLine("El total de dinero del banco es:", total);
                this.cliente1.imprimir();
                this.cliente2.imprimir();
                this.cliente3.imprimir();
            }
        }
        
        public static object banco1 = Banco();
        
        static Module() {
            banco1.operar();
            banco1.depositos_totales();
        }
    }
}
