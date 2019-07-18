# Uelinton---Credito-e-Debito
Método adicionado na API SettleCreditDebit

# Ao finalizar este projeto, vamos alçancar os seguintes objetos:

- API Rest desenvolvida em C# .net core;
- Implementação DDD;
- Repository; 
- Mapper; 
- ORM EntityFramework;
- swagger;
- Documentação api em swagger;
- XUnit Test


# Métodos de Transferência e Efetivar transferências. 
- Transferência, é um método que será disponibilizado para empresas estar executando suas transferências ou de terceiros(seus respectivos clientes).
- Efetivar transferências, método que será utilizado pelo microserviço, responsável por evetivar a transferência de fato. 

# Serviço do Windows desenvolvido na arquitetura Microservices.

- Responsável por checar a todo momento se existe transferências pendentes. No momento em que existe alguma transferência, o microservices é responsável por enviar uma requisição via http chamando o método "Efetivar transferencias", para efetivar a transferencia de fato.

- Este conceito é utilizado para enviar diversos requests com curtos espaços tempo, muito utilizado por grandes empresas, que tenha uma quantidade enorme de envios de requisições diáriamente, sem a necessidade de uma interação de usuário final.


# Respostas

- 1 - Domain Driver Design é uma modelagem de Software, que ajuda a orquestrar um conjunto de práticas e padrões com o objetivo de implementar um projeto mais claro, organizado, modulavel. Cada dominio com a sua responsabilidade, separar regras do processo de negócio, tornando um projeto mais entendivel e de fácil manutenção.

- 2 - Microservices é uma arquitetura de criação de software, são micro programas que não possui dependência com outros programas ou fatores, ele possui uma unica responsabilidade com o foco de grandes entregas de processamento de dados. Quando o mesmo passa a ter mais que uma responsabilidade e ganha dependências de outros programas, logo deixa de ser um microservices gerando grandes problemas para o processo em si.
Ele possui um grande poder de escalabilidade se implementado da forma correta, o seu processo passa a ser vantajoso quando na entrega de sua unica responsabilidade, caso aconteça algum problema com o microservices a operação não irá parar 100% não deverá impactar nos outros demais serviços, somente uma parte, uma responsabilidade ficará inativa até que o reparo seja aplicado. Mais fácil de aplicar manutenções e identificar problemas sem interferir nos outros produtos.
É uma arquitetura complexa de inplementetar, deve ser bem pensada antes de aplicar em seu negócio, está arquitetura deve ser implementada de uma forma que os processos se comunique sem aplicar dependências no microservices distintos. É focado em escalabilidade e entregas continuas. Mas deve haver uma preocupação ao desenvolver uma aplicação distribuida, quando a IDE não da suporte para isso, e sim para aplicações monoliticas.

- 3 - Falando em comunicação, assíncrona é de grande utilização por e-mails, sms, etc. Quando o remetente não espera um retorno imediato do recebedor.

- Assíncrono em blocos de códigos de programação, acontecem no mesmo conceito, o código não ficará preso esperando uma resposta de algum método ou funcionalidade, a linha de código continuará percorrendo toda a sua rotina de uma forma independente.

- Síncrono é totalmente o contrário. O bloco de código só será executado com a finalização de outro bloco. Então é aguardado uma resposta de uma funcionalidade método, para outra linha de código ser executada.

- Um bom senário para aplicar a programão assíncrona, é em uma operação de carga de dados. Onde o usuário clica em um botão para ver os dados serem carregados, mas a tela ficar congelada, esperando finalizar o processo de carga.

- Com a programação assíncrona isso poder ser resolvido, a tela não ficará bloqueada, e os dados serão carregados em paralelo. 

- Já a programação síncrona, estamos rodeados dela. Um exemplo claro, é um formulário de criar e salvar um novo cliente. Neste processo aguardamos uma resposta momentânea, para prosseguir com os próximos passos referente ao cliente. 
