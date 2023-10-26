Descripción del Proyecto
Este proyecto en Unity es un juego en primera persona donde el jugador se enfrenta a enemigos que persiguen y atacan. Se ha implementado un sistema de salud (VidaJugador) y un arma de rayos láser (RaycastGun) para que el jugador pueda defenderse.

Cómo Usar los Scripts
Script persecucion
Este script controla el comportamiento del enemigo que persigue al jugador.

Variables Públicas:

myEnemy: Asigna el componente NavMeshAgent del enemigo en el Inspector de Unity. Permite al enemigo moverse utilizando navegación.
myPlayer: Asigna el objeto del jugador que el enemigo persigue.
vidaJugador: Asigna el script VidaJugador para gestionar la salud del jugador.
Método OnCollisionEnter:

Detecta colisiones con otros objetos. Si el objeto colisionado tiene el tag "Player", se llama a vidaJugador.ReducirVida(5f) para reducir la salud del jugador en 5 unidades.
Método Update:

Se llama en cada frame del juego y actualiza el destino del enemigo (myEnemy) para que persiga al jugador.
Script RaycastGun
Este script maneja el arma del jugador, que dispara rayos láser para destruir cubos y esferas.

Variables Públicas:

playerCamera: Asigna la cámara del jugador en el Inspector de Unity.
laserOrigin: Punto de origen del láser.
gunRange: Rango de disparo del arma.
fireRate: Velocidad de disparo.
laserDuration: Duración del láser en segundos.
contadorTexto: Asigna un objeto de tipo texto (UI) para mostrar el contador de cubos y esferas destruidos.
Método Update:

Controla el disparo del láser. Si se presiona el botón de disparo y ha pasado el tiempo de recarga (fireRate), dispara un rayo láser.
Método ShootLaser:

Habilita y deshabilita el renderizado del láser.
Método HandleHit:

Gestiona las colisiones del rayo láser con objetos, llevando un contador de golpes en cubos y esferas.
Script VidaJugador
Este script controla la salud del jugador y la actualización de la barra de vida en la UI.

Variables Públicas:

vidaMaxima: La salud máxima que puede tener el jugador.
vidaActual: La salud actual del jugador.
barraVida: La imagen de la barra de vida en la UI.
Método Update:

Actualiza la visualización de la barra de vida en la UI.
Método ReducirVida:

Reduce la salud actual del jugador en la cantidad especificada.