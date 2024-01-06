# Do que se trata? 
API pura feita com C# e .NET

Feita para ser um hub de modelos e ideais de banco de dados para várias aplicações

Endpoints:

``` curl
GET http://localhost:5166/api/modelo

 {
        "id": 7,
        "titulo": "Banco de Dados Saude S",
        "imagemURL": "http://img/saudes.png",
        "categoriaId": 1
    },
    {
        "id": 1,
        "titulo": "Ecommerce Idea",
        "imagemURL": "http://files.com/amazon-db.png",
        "categoriaId": 2
    }

```

``` curl

GET http://localhost:5166/api/categoria


{
        "id": 1,
        "nome": "Saude",
        "modelos": [
            {
                "id": 3,
                "titulo": "Modelo de Sistema de Saude",
                "imagemURL": "http://img/,",
                "categoriaId": 1
            },
            {
                "id": 4,
                "titulo": "Banco de Dados SUST",
                "imagemURL": "http://img/,",
                "categoriaId": 1
            },
            {
                "id": 5,
                "titulo": "Banco de Dados UK",
                "imagemURL": "http://img/,",
                "categoriaId": 1
            },
            {
                "id": 7,
                "titulo": "Banco de Dados Saude S",
                "imagemURL": "http://img/saudes.png",
                "categoriaId": 1
            }
        ]
    },
    {
        "id": 2,
        "nome": "Ecommerce",
        "modelos": [
            {
                "id": 1,
                "titulo": "Ecommerce Idea",
                "imagemURL": "http://files.com/amazon-db.png",
                "categoriaId": 2
            },
            {
                "id": 10,
                "titulo": "Ecommerce Idea",
                "imagemURL": "http://files.com/amazon-db.png",
                "categoriaId": 2
            }
        ]
    }

```

```curl

POST http://localhost:5166/api/modelo

{
  "Titulo": "Ideia para Comercio",
  "ImagemURL": "http://drive.google.com/usuario/database.png",
  "CategoriaId": 2
}

```
