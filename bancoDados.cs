// Executar no terminal pra acessar o servidor
mongosh "mongodb+srv://cluster0.q2grp.mongodb.net/" --apiVersion 1 --username Admin

// Acessar ou criar um banco
use

// Verificar os bancos existentes
show dbs

// Verificar as coleções de um banco
show collections

// Criar uma coleção
db.createCollection("")

// Dentro da coleção
db.produtos.insertMany