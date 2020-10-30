# DependencyInversion

Preciso da interface do Repositorio (IRepository) para testar o Handler.

Preciso da interface do Handler (IHandler) para testar o Controller.

###### Testes
Para que uma classe se torne testável, é necessária que ela não dependenda da implementação de outras classes, mas de abstrações delas (interfaces).

###### Teste e Acoplamento
Teste e acoplamento estão diretamente ligados. Para diminuir o acoplamente utilizamos a Injeção de Dependência. E para que essa injeção não dificulte
os testes elas precisam ser abstrações. Injeção de abstrações. 
