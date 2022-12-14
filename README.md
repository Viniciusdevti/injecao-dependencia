# injecao-dependencia
* Projeto com Injeção de dependência e inversão de controle

Nesse projeto temos a classe ImpostoService, que é responsável por calcular o imposto. Caso a classe tivesse que calcular o imposto, para cada estado dentro da service, o código ficaria acoplado e com várias responsabilidades. 

Para resolver isso, definimos uma inteface IImpostEstado, que contém a assinatura CalcularImposto, comum em nas classes de impostos para todos os estados.

Com isso o ImpostoService passa a receber no construtor um parâmetro do tipo IImpostEstado, fazendo quem está  criando a instância da classe definir qual dependência vai usar. Utilizando assim o princípio da injeção de dependência e inversão de controle.
