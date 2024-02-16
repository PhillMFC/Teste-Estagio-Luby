# ENUNCIADO

Resolva as questões utilizando as tabelas abaixo como referência

```shell
+----+--------------+
| tabela_pessoa     |
+----+--------------+
| id | nome         |
+----+--------------+
|  1 | John Doe     |
|  2 | Jane Doe     |
|  3 | Alice Jones  |
|  4 | Bobby Louis  |
|  5 | Lisa Romero  |
+----+--------------+
+----+----------------+-----------+
| tabela_evento                   |
+----+----------------+-----------+
| id | evento         | pessoa_id |
+----+----------------+-----------+
|  1 | Evento A       |  2        |
|  2 | Evento B       |  3        |
|  3 | Evento C       |  2        |
|  4 | Evento D       |  NULL     |
+----+----------------+-----------+
```

- 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.
- 2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
- 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
- 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe' 
- 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.
- 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.
  
> Gerênciamento de tabelas

- 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
- 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\ 
```shell
    id: int (PK)
    telefone: varchar(200)
    pessoa_id: int(FK)
```
- 2.9 Crie uma query para criar uma índice do tipo **único** na coluna telefone da 'tabela_telefone'.
- 2.10 Crie uma query para remover a 'tabela_telefone'.



# RESOLUÇÃO


Inicialmente, utilizando uma instância online do sistema gerenciador de banco de dados PostgreSQL, criei as tabelas `PESSOA` e `EVENTO`

```sql
CREATE TABLE PESSOA(
	id INT,
  	nome VARCHAR(255)
);
```

```sql
CREATE TABLE EVENTO(
	id INT,
  	EVENTO VARCHAR(255),
    PESSOA_ID INT
);
```

Em seguida, as informações são adicionadas às tabelas 

```sql
INSERT INTO pessoa (ID, nome)
VALUES
  (1,'John Doe'),
  (2,'Jane Doe'),
  (3,'Alice Jones'),
  (4,'Bobby Louis'),
  (5,'Lisa Romero');
```

```sql
INSERT INTO evento (ID, evento, pessoa_id)
VALUES
  (1,'EVENTO A',2),
  (2,'EVENTO B',3),
  (3,'EVENTO C',2),
  (4,'EVENTO D', NULL);
```

### Questão 2.1

```sql
SELECT pessoa_id, evento, nome
FROM evento 
INNER JOIN pessoa ON evento.pessoa_id = pessoa.id;	
```

### Questão 2.2

```sql
SELECT id, nome 
FROM pessoa
WHERE nome LIKE '%Doe'
```
### Questão 2.3

```sql
INSERT INto evento
VALUES (5, 'EVENTO E', (
  SELECT ID FROM pessoa
  WHERE pessoa.nome = 'Lisa Romero'));'
```

### Questão 2.4

```sql
UPDATE evento
SET pessoa_id = (
  SELECT id 
  FROM pessoa
  WHERE nome = 'John Doe')
WHERE evento = 'EVENTO D';
```

### Questão 2.5

```sql
DELETE FROM evento
WHERE evento = 'EVENTO D';
```

### Questão 2.6

```sql
DELETE FROM pessoa
WHERE id NOT IN(
  select pessoa_id
  FROM evento);
```

### Questão 2.7

```sql
ALTER TABLE pessoa
ADD idade INT;
```

### Questão 2.8

```sql
ALTER TABLE pessoa ADD CONSTRAINT id_fk UNIQUE (id);

CREATE TABLE telefone (
    id SERIAL PRIMARY KEY,
    telefone VARCHAR(200),
  	pessoa_id INTEGER REFERENCES pessoa(id));
```

### Questão 2.9

```sql
ALTER TABLE telefone ADD CONSTRAINT telefone_fk UNIQUE (telefone);

```

### Questão 2.10

```sql
DROP TABLE telefone;

```




