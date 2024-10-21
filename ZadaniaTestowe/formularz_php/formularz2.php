<?php
// Sprawdzanie, czy formularz został wysłany
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Pobieranie danych z formularza
    $name = htmlspecialchars($_POST['name']);
    $email = htmlspecialchars($_POST['email']);

    // Wyświetlanie otrzymanych danych
    echo "<h1>Dziękujemy za rejestrację!</h1>";
    echo "<p>Twoje imię: " . $name . "</p>";
    echo "<p>Twój email: " . $email . "</p>";
} else {
    echo "<h1>Błąd: Brak danych do przetworzenia!</h1>";
}
?>
