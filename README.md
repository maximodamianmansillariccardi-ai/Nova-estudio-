# PROJECT STRIKE — Unity Android Starter

Este paquete es una base de código para comenzar un shooter 3D móvil en Unity.
**No es el juego completo ni un APK instalable.** Incluye scripts iniciales; todavía hace falta crear/importar modelos, escenas, animaciones, interfaz, configurar Unity/Android y compilar.

## Tecnología recomendada
- Unity LTS con plantilla 3D (URP opcional).
- Orientación: Landscape Left/Right.
- Objetivo inicial: Android ARM64.
- Gráficos equilibrados y opciones de calidad.
- Para el multijugador: servidor dedicado/autoritativo y un servicio de cuentas. No se incluye un backend online en este starter.

## Scripts incluidos
- `PlayerMotor.cs`: movimiento básico relativo a cámara.
- `MobileLook.cs`: control táctil de cámara.
- `WeaponRaycast.cs`: disparo por raycast con daño local de ejemplo.
- `Health.cs`: salud básica.
- `GlooWallPlacer.cs`: coloca una pared defensiva con enfriamiento.
- `SensitivitySettings.cs`: guarda sensibilidad local.
- `ProjectStrikeGameManager.cs`: configuración inicial, modo horizontal y calidad gráfica.

## Cómo probar en Unity
1. Crea un proyecto 3D en Unity Hub.
2. Copia `Assets/ProjectStrike/Scripts` dentro de la carpeta `Assets` de tu proyecto.
3. Crea una escena con un suelo, paredes y un objeto Player con `CharacterController`.
4. Añade una cámara como hija de Player y asigna las referencias en el Inspector.
5. Añade `Health` a los objetivos de prueba.
6. Crea botones táctiles en un Canvas y conéctalos a los métodos públicos de los scripts.
7. En Player Settings configura Android y Landscape.
8. Prueba en dispositivo antes de preparar una compilación.

## Importante
Los disparos y la salud de este ejemplo funcionan localmente. Para partidas online reales, el servidor debe validar movimiento, impactos, inventario, monedas, rangos y recompensas. Nunca guardes contraseñas ni recompensas competitivas solo en el cliente.
