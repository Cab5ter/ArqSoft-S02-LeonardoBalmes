# Viborita 🐍

Juego de la víbora (Snake) desarrollado en C# como consola interactiva, dentro de un proyecto que también incluye el clásico Ahorcado.

---

## ¿De qué trata?

La Viborita es el clásico juego Snake: controlás una serpiente que se mueve por un tablero, comés comida para crecer y ganar puntos, y perdés si chocás contra una pared o contra vos mismo. El objetivo es llegar a 10 puntos.

---

## ¿Qué hicieron?

- Implementaron el motor del juego (`MotorViborita`) con lógica de movimiento, colisiones y generación aleatoria de comida.
- Implementaron la interfaz de consola (`ConsolaUIViborita`) que dibuja el tablero en tiempo real usando caracteres ASCII.
- Integraron la Viborita al menú principal junto al Ahorcado, permitiendo elegir entre ambos juegos al iniciar.
- Aplicaron el principio de separación de responsabilidades usando la interfaz `IMotorJuego`.

---

## ¿Cómo funciona?

Al iniciar el programa se muestra un menú para elegir entre Ahorcado y Viborita. Al seleccionar la Viborita:

1. Se genera un tablero de 20×15 celdas.
2. La víbora arranca con 3 segmentos en el centro, moviéndose hacia la derecha.
3. El jugador controla la dirección con las **flechas del teclado**.
4. Cada vez que la víbora come (`*`), crece un segmento y suma un punto.
5. El juego termina si la víbora choca con una pared o consigo misma.
6. **Ganar:** llegar a 10 puntos. **Perder:** colisión.

| Símbolo | Significado |
|---------|-------------|
| `@`     | Cabeza de la víbora |
| `o`     | Cuerpo de la víbora |
| `*`     | Comida |

**Teclas:**
- `↑ ↓ ← →` — mover
- `Q` — salir

---

## Cláusula de IA

Este proyecto fue desarrollado con asistencia de inteligencia artificial (Claude de Anthropic). La IA fue utilizada como herramienta de apoyo para la escritura y revisión de código. Todo el contenido fue revisado y validado por el autor.
