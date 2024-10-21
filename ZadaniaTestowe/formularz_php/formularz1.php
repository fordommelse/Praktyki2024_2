<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formularz rejestracyjny</title>
</head>
<body>
    <h1>Rejestracja</h1>
    <form action="register.php" method="POST">
        <label for="name">Imię:</label><br>
        <input type="text" id="name" name="name" required><br><br>

        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" required><br><br>

        <input type="submit" value="Zarejestruj">
    </form>
</body>
</html>
