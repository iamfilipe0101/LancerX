# 🚗 Sistema LancerX — Locadora de Carros (Arquitetura Completa)

> O mapa do sistema inteiro. Estrutura de tabelas, telas, menus e ordem de construção. 👊

---

## 🎯 O que o sistema faz

Uma locadora que aluga carros Lancer. Controla: os carros (frota), os clientes, e as locações (quem alugou qual carro, quando pegou, quando devolveu). Com login e níveis de acesso (Admin/Atendente).

---

## 🧱 AS TABELAS (banco de dados)

### Tabela Usuarios (já existe!)
Quem opera o sistema.
| Coluna | Tipo | Obs |
|---|---|---|
| Id | INT IDENTITY | chave |
| Login | VARCHAR(50) | |
| Senha | VARCHAR(50) | |
| NomeCompleto | VARCHAR(100) | |
| Cargo | VARCHAR(50) | Admin / Atendente |

### Tabela Clientes
Quem aluga os carros.
| Coluna | Tipo | Obs |
|---|---|---|
| Id | INT IDENTITY | chave |
| Nome | VARCHAR(100) | |
| CPF | VARCHAR(14) | identificador (com pontos/traço) |
| CNH | VARCHAR(20) | carteira de motorista (obrigatória p/ alugar!) |
| Telefone | VARCHAR(20) | |
| Email | VARCHAR(100) | |
| Endereco | VARCHAR(200) | opcional |

### Tabela Carros
A frota de Lancers.
| Coluna | Tipo | Obs |
|---|---|---|
| Id | INT IDENTITY | chave |
| Placa | VARCHAR(10) | identificador único do carro |
| Modelo | VARCHAR(50) | ex: Lancer GT, Lancer Evolution |
| Ano | INT | |
| Cor | VARCHAR(30) | |
| ValorDiaria | DECIMAL(10,2) | quanto custa por dia |
| Disponivel | BIT | true = livre, false = alugado |

### Tabela Locacoes (o coração do sistema)
Registra cada aluguel — liga cliente + carro.
| Coluna | Tipo | Obs |
|---|---|---|
| Id | INT IDENTITY | chave |
| ClienteId | INT | qual cliente (liga na tabela Clientes) |
| CarroId | INT | qual carro (liga na tabela Carros) |
| DataRetirada | DATE | quando pegou |
| DataPrevistaDevolucao | DATE | quando deve devolver |
| DataDevolucaoReal | DATE | quando devolveu de fato (vazio até devolver) |
| ValorTotal | DECIMAL(10,2) | diária × dias |
| Status | VARCHAR(20) | "Aberta" / "Fechada" |

🆕 **Conceito novo:** o `ClienteId` e `CarroId` são "ligações" (chaves estrangeiras) — em vez de repetir o nome do cliente na locação, você guarda só o Id dele e "busca" quando precisa. Isso conecta as tabelas.

---

## 🖥️ AS TELAS (forms)

### Já feitas ✅
- **FrmLogin** — entrada
- **FrmPrincipal** — MDI + menu
- **FrmAviso** — avisos
- **FrmCadastroUsuario** + **FrmListaUsuarios** — CRUD de usuários

### A fazer
- **FrmCadastroCliente** + **FrmListaClientes** — CRUD de clientes
- **FrmCadastroCarro** + **FrmListaCarros** — CRUD da frota
- **FrmNovaLocacao** — registrar aluguel (escolhe cliente + carro + datas)
- **FrmDevolucao** — fechar aluguel (marca devolução, calcula valor)
- **FrmLocacoesAbertas** — ver o que tá alugado

Padrão: cada "coisa" tem uma tela de **lista** (grid + botões) e uma de **cadastro/edição** (os campos). Igual você já fez pra usuários.

---

## 📋 OS MENUS (MenuStrip)

```
Cadastros          Locações              Relatórios          Administrador    Sistema
  Clientes           Nova Locação          Locações Abertas    Usuários         Logoff
  Carros             Devolução             Frota Disponível    (só Admin)       Sair
                                           Histórico
```

- **Cadastros** → clientes e carros (CRUD)
- **Locações** → alugar e devolver (as ações do dia a dia)
- **Relatórios** → consultas (o que tá alugado, quais carros livres)
- **Administrador** → usuários (só Admin vê)
- **Sistema** → logoff, sair (já tem!)

---

## 🚀 ORDEM DE CONSTRUÇÃO (por fases)

### FASE 1 — Cadastros básicos (você JÁ sabe fazer isso!)
1. Tabela + CRUD de **Clientes** (lista, incluir, editar, excluir)
2. Tabela + CRUD de **Carros**

É o mesmo CRUD dos usuários — só muda os campos. Reaproveita tudo que aprendeu. Faz um, depois o outro.

### FASE 2 — A locação (o desafio novo) 🆕
3. **Nova Locação:** escolhe um cliente (ComboBox ou lista), escolhe um carro DISPONÍVEL, define datas, calcula o valor. Ao salvar: cria a locação E marca o carro como indisponível.
4. **Devolução:** lista locações abertas, escolhe uma, marca devolução. Ao fechar: marca o carro como disponível de novo.

Aqui tá o coração — relacionar as tabelas. Conceito novo, a gente faz com calma.

### FASE 3 — Relatórios e refinos
5. Telas de consulta (locações abertas, frota disponível)
6. Cálculo de multa por atraso, etc.

---

## 🆕 OS CONCEITOS NOVOS QUE VÃO APARECER

| Conceito | Onde | O que é |
|---|---|---|
| Chave estrangeira (ClienteId, CarroId) | tabela Locacoes | ligar uma tabela na outra |
| JOIN (juntar tabelas no SELECT) | listar locações | mostrar nome do cliente + placa do carro juntos |
| ComboBox carregado do banco | Nova Locação | escolher cliente/carro de uma lista vinda do SQL |
| DateTimePicker | datas | campo de calendário pra escolher data |
| Cálculo entre datas | valor da locação | dias × diária |
| Transação (opcional/avançado) | salvar locação | garantir que tudo salva junto |

---

## 🎯 SUGESTÃO: por onde começar AGORA

Você acabou de fazer o CRUD de usuários. O próximo passo natural é o **CRUD de Clientes** — é praticamente idêntico, só muda os campos. Isso:
1. Fixa o que você aprendeu (repetir o padrão CRUD com banco)
2. É rápido (você já domina)
3. Te deixa pronto pra atacar a locação (que precisa de clientes e carros existindo)

**Ordem imediata:**
1. Cria a tabela `Clientes` no SSMS (CREATE TABLE)
2. Cria a classe `Cliente` (opcional, ou trabalha direto com o banco)
3. FrmListaClientes (grid) + FrmCadastroCliente (campos)
4. CRUD completo (incluir, editar, excluir — igual usuários)
5. Depois, mesma coisa pra Carros
6. AÍ ataca a locação

---

## 💡 Sobre o cadastro de CLIENTE (tua pergunta)

O que um cliente de locadora precisa ter:
- **Nome** (obrigatório)
- **CPF** (identificador — importante pra não duplicar cliente)
- **CNH** (carteira — ESSENCIAL numa locadora, sem carteira não aluga!)
- **Telefone** (contato)
- **Email** (contato)
- **Endereço** (opcional, mas útil)

O **CPF** e a **CNH** são os campos que diferenciam de um cadastro comum — locadora precisa saber que a pessoa pode dirigir legalmente. Considera validar que o CPF não repete (um SELECT antes de inserir, igual o ContainsKey).

---

## 🔑 Lição-mãe

**Todo o sistema é o CRUD que você já domina, repetido pra cada "coisa" (cliente, carro), MAIS a locação que liga tudo.** A Fase 1 (clientes, carros) é repetição do que você sabe — rápido. A Fase 2 (locação) é o desafio novo: relacionar tabelas (ClienteId, CarroId), o que exige JOIN e chaves estrangeiras. Constrói na ordem: cadastros primeiro (base), locação depois (usa a base). Cada "coisa" = tela de lista + tela de cadastro. 👊

Começa pela tabela + CRUD de Clientes. Manda a tabela criada e a gente segue!