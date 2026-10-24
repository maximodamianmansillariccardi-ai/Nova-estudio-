# PROJECT STRIKE — ruta de desarrollo

## Diseño ya definido
- Shooter 3D en primera persona, horizontal.
- Gráficos equilibrados con ajuste por dispositivo.
- Inicio de sesión previsto: Google y correo.
- Controles táctiles personalizables, sensibilidad configurable.
- Personajes y habilidades propias; armas, skins y paredes defensivas.
- Mapas, vehículos, modos casuales y clasificatorios, rangos y niveles.
- Economía ganada jugando; tienda, inventario, ruleta mensual y pase de temporada.
- Chat de voz opcional y reportes de conducta.

## Sistemas que requieren trabajo adicional
1. Arte 3D, animaciones, sonidos, interfaz y mapas terminados.
2. Backend de cuentas y recuperación segura de acceso.
3. Multijugador en tiempo real, matchmaking y servidores autoritativos.
4. Persistencia de inventario, monedas, rangos y temporadas.
5. Chat de voz con permisos, moderación y controles de privacidad.
6. Antitrampas en servidor, validación de movimientos y revisión de reportes.
7. Pruebas de rendimiento, batería, red, seguridad y compatibilidad.
8. Cumplimiento de políticas de Google Play, clasificación por edades y privacidad.
9. Compilación firmada AAB, pruebas internas y publicación.

## Principio de seguridad competitiva
El cliente no debe decidir por sí solo monedas, impactos, rangos ni recompensas. La lógica crítica debe ejecutarse o validarse en el servidor. No existe antitrampas perfecto; se combinan validación, detección, reportes y actualizaciones.
