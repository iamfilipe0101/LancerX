# 🏢 Exercício Avançado: Sistema de Gestão com Login + MDI

> Nível: o mais complexo até agora. É a estrutura de um sistema corporativo REAL. Vai por partes! 👊

---

## 🎯 O que você vai construir

Um sistema de gestão de uma pequena empresa, com:
1. **Tela de Login** (usuário + senha) — só entra quem tem credencial
2. **Janela Principal MDI** com MenuStrip no topo
3. Vários módulos abrindo DENTRO da principal (MDI children)
4. Controle de quem tá logado (mostra o nome do usuário)

Tema sugerido: **Sistema de uma Locadora** (ou adapta pro que quiser — oficina, clínica, papelaria). Vou usar locadora de exemplo.

---

## 🆕 Conceitos NOVOS que esse projeto ensina

| Conceito | Por que é novo |
|---|---|
| Tela de login (fluxo de entrada) | controlar acesso antes de abrir o sistema |
| Trocar o form inicial (Program.cs) | o programa começa no login, não na principal |
| Passar dados do login pra principal | quem logou? mostrar o nome |
| MDI Parent/Child de verdade | várias telas dentro da principal |
| MenuStrip organizando módulos | navegação profissional |
| Impedir abrir a mesma tela 2x | controle de janelas filhas |
| Classe Usuario | modelar quem acessa |

---

## 🧱 As classes (Models)

### Classe Usuario
| Propriedade | Tipo |
|---|---|
| Login | string |
| Senha | string |
| NomeCompleto | string |
| Cargo | string (ex: Admin, Atendente) |

### Classe Cliente (o que o sistema gerencia)
| Propriedade | Tipo |
|---|---|
| Codigo | string |
| Nome | string |
| Telefone | string |
| Email | string |

(Se quiser, adiciona mais módulos depois: Filmes, Locações, etc.)

---

# 🚀 ETAPAS

## ETAPA 1 — Tela de Login
- [ ] Cria o form `FrmLogin`: campos Usuário, Senha (TextBox), botão Entrar
- [ ] 🆕 No campo senha, propriedade `PasswordChar = *` (esconde a senha com asteriscos)
- [ ] Uma `List<Usuario>` com 2-3 usuários de teste (no construtor)
- [ ] Botão Entrar: procura um usuário com login E senha batendo
  - Dica LINQ: `usuarios.FirstOrDefault(u => u.Login == txtLogin.Text && u.Senha == txtSenha.Text)`
  - Se achou (não é null) → abre a principal
  - Se não achou (null) → aviso "usuário ou senha inválidos"

**Teste:** login errado → bloqueia. Login certo → abre a principal (por enquanto vazia).

## ETAPA 2 — Program.cs começa no Login 🆕
- [ ] 🆕 No `Program.cs`, muda pra abrir o `FrmLogin` primeiro (não a principal):
  ```
  Application.Run(new FrmLogin());
  ```
- [ ] O login, quando dá certo, abre a principal E se fecha

**Teste:** o programa abre no login, não na principal.

## ETAPA 3 — Passar o usuário logado pra Principal 🆕
- [ ] A `FrmPrincipal` recebe o `Usuario` que logou (pelo construtor — padrão forms conversando!)
- [ ] Mostra numa barra (StatusStrip embaixo ou um Label): "Logado como: Fulano - Admin"
- [ ] 🆕 No login, ao dar certo:
  ```
  FrmPrincipal principal = new FrmPrincipal(usuarioLogado);
  principal.Show();
  this.Hide();   // esconde o login
  ```

**Teste:** loga, e a principal mostra o nome de quem logou.

## ETAPA 4 — MDI + MenuStrip
- [ ] `FrmPrincipal`: propriedade `IsMdiContainer = True`
- [ ] Adiciona um `MenuStrip` no topo com os menus:
  ```
  Cadastros        Movimentações      Sistema
    Clientes         Nova Locação       Trocar Usuário
    Filmes           Devolução          Sair
  ```
- [ ] Cada item de menu abre a tela como FILHA:
  ```
  FrmClientes tela = new FrmClientes();
  tela.MdiParent = this;
  tela.Show();
  ```

**Teste:** clica em Cadastros > Clientes, a tela abre DENTRO da principal.

## ETAPA 5 — Módulo Clientes (CRUD dentro do MDI)
- [ ] `FrmClientes` como filha MDI
- [ ] DataGridView + cadastro/editar/excluir (você já sabe fazer CRUD!)
- [ ] A `List<Cliente>` ou `Dictionary` precisa "sobreviver" — decisão de design (veja nota abaixo)

**Teste:** cadastra clientes, aparecem no grid, dentro da principal.

## ETAPA 6 — Impedir abrir a mesma tela 2x 🆕
Problema: se o usuário clica em "Clientes" 3 vezes, abrem 3 telas iguais! Feio.
- [ ] 🆕 Antes de abrir, checa se já tem uma aberta:
  ```
  // percorre as filhas já abertas
  foreach (Form filha in this.MdiChildren)
  {
      if (filha is FrmClientes)
      {
          filha.Activate();   // traz a que já existe pra frente
          return;             // não abre outra
      }
  }
  // se não achou, abre nova
  ```

**Teste:** clica em Clientes várias vezes → só abre uma, e traz pra frente.

## ETAPA 7 — Trocar Usuário / Logout 🆕
- [ ] Item de menu "Trocar Usuário": fecha a principal e volta pro login
- [ ] Item "Sair": `Application.Exit()`

**Teste:** trocar usuário volta pro login; sair fecha tudo.

---

## 🤔 NOTA DE DESIGN: onde os dados moram no MDI?

Esse é o maior desafio conceitual. No projeto anterior, a lista morava no MenuPrincipal e você passava pra cada tela. No MDI é parecido, MAS:

- Se cada filha tem sua própria lista, os dados somem quando ela fecha 🚨
- A lista de clientes precisa "viver" enquanto o sistema tá aberto

**Solução simples pra agora:** a `FrmPrincipal` guarda as listas (clientes, filmes...) e passa pras filhas quando abre — igual você já fazia. A principal é a "dona" dos dados, as filhas só mexem.

**Solução avançada (pra saber que existe):** uma classe estática de "repositório" que todos acessam. Mas deixa pra depois — passar pela principal resolve.

---

# 🎓 Desafios extras (se sobrar gás)

1. **Cargo define acesso:** se o usuário é "Atendente", esconde o menu de Cadastros (só Admin vê). Usa o Cargo do usuário logado.
2. **Data/hora na barra:** mostra a hora atual num canto (com Timer).
3. **Confirmar saída:** ao fechar, pergunta "Tem certeza?" (FormResult)
4. **Salvar usuários em arquivo:** persistir os logins (bem avançado)
5. **Contador de janelas abertas** na barra de status

---

# 🔑 Por que esse projeto é importante

Essa é a **espinha dorsal de 90% dos sistemas corporativos**: login → tela principal → módulos. Aquele sistema de logística que você mostrou tem exatamente essa estrutura. Se você domina isso, você consegue montar o esqueleto de QUALQUER sistema de gestão.

**Lição-mãe:** você já sabe todas as peças (forms conversando, CRUD, validação, MDI). Esse projeto é JUNTAR tudo numa arquitetura profissional. O novo aqui não são as peças — é a ORGANIZAÇÃO delas num sistema completo. Vai por etapas, testa cada uma, e me chama quando travar. 👊

---

# 📋 Ordem de ataque (resumo)

1. FrmLogin (campos + validação com LINQ)
2. Program.cs abre o login
3. Login passa usuário pra Principal
4. Principal vira MDI + MenuStrip
5. Módulo Clientes (CRUD) como filha
6. Impedir tela duplicada
7. Trocar usuário / Sair

Começa pela ETAPA 1 (a tela de login). Monta e me manda!
