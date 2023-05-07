**Parcial 3 - Scripting (2023-1)**
----
**Integrantes:**
+ Ximena Alejandra Duarte Chamorro
+ Pan
+ Queso

Cambios Principales
----
1. Se establecieron los scripts que se pedían como singleton para poder acceder a ellos cómodamente
2. Al script `RefactoredGameController` se le agregaron 3 eventos (actions específicamente): `UpdateScore` para cuando se agregan puntos, `UpdateUI` para actualizar el UI al agregar puntos y `GameOver` para finalizar la partida. Adicionalmente, se definieron 2 métodos adicionales para poder llamar los eventos. Quedó con 3: `DestroyObstacle`, `OnScoreChanged` y `SetGameOver`
3. Para `RefactoredPlayerController` se agregó un evento/action para actualizar el ícono de la bala actual en el UI, y se agregó una variable para modificar el tiempo de vida de la bala a placer. En este script se suscriben los métodos `UpdateScore` y `OnGameOver` del script base a los eventos respectivos en el `RefactoredGameController`. Además, se definen los 2 métodos para disparar y seleccionar la bala, que emplean el sistema de pool para funcionar.
4. En el `RefactoredUIManager` lo principal es que se suscriben los métodos del script base, `UpdateScoreLabel` y `OnGameOver` a los eventos respectivos del `RefactoredGameController`y el de `EnableIcon` al evento respectivo del `RefactoredPlayerController`
5. Al script de `RefactoredObstacleSpawner` solo se le tuvo que definir el método de `SpawnObject` para que tomase un objeto de un pool random (Low, Mid o Hard) y le cambie la posición para simular el instanciamiento
6. `RefactoredObstacle` no tuvo muchos cambios, solo se le tuvo que definir el método `DesrtroyObstacle` para que aumentase puntos si lo destruye el player, y se recicle en el pool.
7. Se creó un script, `PoolableObject` con un evento para reciclarlo, un método que lo invoca, y una corrutina que recicla el objeto después de un tiempo para usarla en las balas.
8. `PoolBase` es donde más hubo que jugar, porque aquí se definen los 3 métodos principales del pooling. Esta vez utilizamos una queue para ir almacenando los objetos. En el método `PopulatePool` se crea una cantidad definida de objetos, se desactivan, y se meten en la cola con Enqueue. `RetrieveInstance` retorna el GameObject que esté disponible en la primera posición de la cola con Dequeue, se activa, y se suscribe al evento de `OnObjectToRecycle` del `PoolableObject`. Así, el flujo del pooling permite que se pueda ir reciclando objetos, y tomando los disponibles de la cola para usarlos. En caso de que no haya objetos suficientes o disponibles, se crea un objeto nuevo para retornarlo, y se agrega al sistema.


 
