### Proyecto 3: Programa de Recompensas y Lealtad

**Descripción del Proyecto:**
El Programa de Recompensas y Lealtad permitirá a los clientes del banco ganar puntos por sus transacciones, los cuales podrán ser canjeados por beneficios y premios. Este sistema tiene como objetivo fomentar la fidelidad del cliente y aumentar la frecuencia de uso de los servicios bancarios.

### Casos de Uso

1. **Registro de Cliente:**

- **Actor:** Cliente
- **Descripción:** Un cliente se registra en el sistema de recompensas proporcionando sus datos personales.
- **Resultado:** El cliente queda registrado en la base de datos y puede comenzar a ganar puntos.

2. **Realización de Transacciones:**

- **Actor:** Cliente
- **Descripción:** Un cliente realiza una transacción (compra, pago de factura, etc.) que es elegible para ganar puntos.
- **Resultado:** La transacción se registra y los puntos correspondientes se acreditan en la cuenta del cliente.

3. **Consulta de Puntos Acumulados:**

- **Actor:** Cliente
- **Descripción:** Un cliente consulta el número de puntos que ha acumulado.
- **Resultado:** El sistema muestra el total de puntos disponibles.

4. **Canje de Recompensas:**

- **Actor:** Cliente
- **Descripción:** Un cliente canjea sus puntos por una recompensa disponible en el catálogo.
- **Resultado:** Los puntos se deducen de la cuenta del cliente y se registra la recompensa canjeada.

5. **Administración de Recompensas:**

- **Actor:** Administrador
- **Descripción:** Un administrador del sistema añade, modifica o elimina recompensas del catálogo.
- **Resultado:** El catálogo de recompensas se actualiza con los cambios realizados.

### Tablas y Descripción de Campos

#### Tabla `Customers` (Clientes)

- **CustomerId** (PK, int): Identificador único del cliente.
- **FirstName** (nvarchar): Nombre del cliente.
- **LastName** (nvarchar): Apellido del cliente.
- **Email** (nvarchar): Correo electrónico del cliente.
- **PhoneNumber** (nvarchar): Número de teléfono del cliente.

  **Descripción:** Esta tabla contiene la información personal de los clientes registrados en el programa de recompensas.

#### Tabla `Transactions` (Transacciones)

- **TransactionId** (PK, int): Identificador único de la transacción.
- **CustomerId** (FK, int): Identificador del cliente que realizó la transacción.
- **TransactionType** (nvarchar): Tipo de transacción (compra, pago, etc.).
- **Amount** (decimal): Monto de la transacción.
- **TransactionDate** (datetime): Fecha y hora de la transacción.

  **Descripción:** Esta tabla registra todas las transacciones realizadas por los clientes que son elegibles para ganar puntos.

#### Tabla `Rewards` (Recompensas)

- **RewardId** (PK, int): Identificador único de la recompensa.
- **RewardName** (nvarchar): Nombre de la recompensa.
- **PointsRequired** (int): Puntos necesarios para canjear la recompensa.

  **Descripción:** Esta tabla contiene el catálogo de recompensas disponibles para que los clientes las canjeen.

#### Tabla `CustomerRewards` (Recompensas del Cliente)

- **CustomerRewardId** (PK, int): Identificador único del registro de recompensa del cliente.
- **CustomerId** (FK, int): Identificador del cliente.
- **RewardId** (FK, int): Identificador de la recompensa.
- **EarnedPoints** (int): Puntos ganados por el cliente.
- **RedeemedPoints** (int): Puntos canjeados por el cliente.

  **Descripción:** Esta tabla registra los puntos ganados y canjeados por cada cliente, así como las recompensas obtenidas.

### Posibles Tablas Adicionales

#### Tabla `RewardCategories` (Categorías de Recompensas)

- **CategoryId** (PK, int): Identificador único de la categoría.
- **CategoryName** (nvarchar): Nombre de la categoría.

  **Descripción:** Esta tabla puede ser útil para organizar las recompensas en categorías (por ejemplo, viajes, productos, servicios).

#### Tabla `RewardTransactions` (Transacciones de Recompensas)

- **RewardTransactionId** (PK, int): Identificador único de la transacción de recompensa.
- **CustomerId** (FK, int): Identificador del cliente.
- **RewardId** (FK, int): Identificador de la recompensa.
- **TransactionDate** (datetime): Fecha y hora del canje de la recompensa.

  **Descripción:** Esta tabla detallaría cada transacción de canje de recompensas realizada por los clientes.
