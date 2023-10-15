# Game CRUD API

- [Game CRUD API](#buber-game-api)
  - [Create Game](#create-game)
    - [Create Game Request](#create-game-request)
    - [Create Game Response](#create-game-response)
  - [Get Game](#get-game)
    - [Get Game Request](#get-game-request)
    - [Get Game Response](#get-game-response)
  - [Update Game](#update-game)
    - [Update Game Request](#update-game-request)
    - [Update Game Response](#update-game-response)
  - [Delete Game](#delete-game)
    - [Delete Game Request](#delete-game-request)
    - [Delete Game Response](#delete-game-response)

## Create Game

### Create Game Request

```js
POST /games
```

```json
{
    "name": "Dota 2",
    "description": "Dota 2, the best toxic games ever !!",
    "startDateTime": "2023-10-14T10:00:00",
    "endDateTime": "2023-10-14T12:00:00",
    "category": [
        "MOBA",
        "Multiplayer",
        "Strategy",
        "PVP",
        "Team-Based",
        "Competitive"
    ],
    "Platform": [
        "PC"
    ]
}
```

### Create Game Response

```js
201 Created
```

```yml
Location: {{host}}/Games/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Dota 2",
    "description": "Dota 2, the best toxic games ever !!",
    "startDateTime": "2023-10-14T10:00:00",
    "endDateTime": "2023-10-14T12:00:00",
    "lastModifiedDateTime": "2023-10-14T16:00:00",
    "category": [
        "MOBA",
        "Multiplayer",
        "Strategy",
        "PVP",
        "Team-Based",
        "Competitive"
    ],
    "Platform": [
        "PC"
    ]
}
```

## Get Game

### Get Game Request

```js
GET /games/{{id}}
```

### Get Game Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Dota 2",
    "description": "Dota 2, the best toxic games ever !!",
    "startDateTime": "2023-10-14T10:00:00",
    "endDateTime": "2023-10-14T12:00:00",
    "lastModifiedDateTime": "2023-10-14T16:00:00",
    "category": [
        "MOBA",
        "Multiplayer",
        "Strategy",
        "PVP",
        "Team-Based",
        "Competitive"
    ],
    "Platform": [
        "PC"
    ]
}
```

## Update Game

### Update Game Request

```js
PUT /games/{{id}}
```

```json
{
    "name": "Dota 2",
    "description": "Dota 2, the best toxic games ever !!",
    "startDateTime": "2023-10-14T10:00:00",
    "endDateTime": "2023-10-14T12:00:00",
    "category": [
        "MOBA",
        "Multiplayer",
        "Strategy",
        "PVP",
        "Team-Based",
        "Competitive"
    ],
    "Platform": [
        "PC"
    ]
}
```

### Update Game Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Games/{{id}}
```

## Delete Game

### Delete Game Request

```js
DELETE /games/{{id}}
```

### Delete Game Response

```js
204 No Content
```