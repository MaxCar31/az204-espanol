## 🚨 GUÍA DE COSTOS POR LABORATORIO (Con Tarjeta de Crédito)

**⚠️ ADVERTENCIA IMPORTANTE**: Los laboratorios que debes **LIMPIAR INMEDIATAMENTE** después de terminar están marcados con 🔴


## 📚 Orden Recomendado de Laboratorios

### **Nivel 200 - Principiante (Inicia aquí)**
1. 01-app-service-deploy-container.md - Implementar una aplicación en contenedores en Azure App Service
2. 01-functions-create-vscode-http.md - Crear una función de Azure con Visual Studio Code

### **Nivel 300 - Intermedio**
3. 01-msal-interactive-auth.md - Implementar autenticación interactiva con MSAL.NET
4. 01-api-mgmt-import-api.md - Importar y configurar una API con Azure API Management
5. 01-app-insights-auto-instrument.md - Monitorear una aplicación con autoinstrumentación
6. 01-container-image-acr-tasks.md - Compilar y ejecutar imagen de contenedor con Azure Container Registry
7. 02-run-container-aci.md - Implementar contenedor en Azure Container Instances
8. 01-event-grid-events-to-endpoint.md - Enrutar eventos con Azure Event Grid
9. 02-app-service-deployment-slots.md - Intercambiar ranuras de implementación

### **Nivel 400 - Avanzado**
10. 01-blob-storage-resources-dotnet.md - Crear recursos de Blob Storage con .NET
11. 02-graph-user-profile.md - Recuperar información de perfil con Microsoft Graph
12. 01-comosdb-create-resources-sdk.md - Crear recursos en Azure Cosmos DB
13. 01-key-vault-store-retrieve.md - Crear y recuperar secretos de Azure Key Vault
14. 02-app-config-retrieve.md - Recuperar ajustes de Azure App Configuration
15. 02-event-hubs-send-receive.md - Enviar y recibir eventos desde Azure Event Hubs
16. 03-deploy-to-container-apps.md - Implementar contenedor en Azure Container Apps

### **Nivel 500 - Experto (Desafío final)**
17. 03-service-bus-send-receive.md - Enviar y recibir mensajes de Azure Service Bus
18. 04-queue-storage-send-receive.md - Enviar y recibir mensajes desde Azure Queue Storage

**Duración total aproximada:** 5-7 horas de laboratorios prácticos.

---

### **NIVEL 200 - Principiante**

#### 1️⃣ **App Service - Deploy Container** 
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **~$0.50 - $2 USD** (laboratorio simple) |
| **📊 Plan recomendado** | Plan B1 (Basic) - ~$12.50/mes |
| **✅ Gratuito** | Primeros 12 meses NO (tendrás que pagar) |
| **⏱️ Duración** | 15 minutos |
| **🔴 RIESGO SI LO DEJAS** | **MODERADO** - Si dejas la app corriendo, pagas por compute |
| **✨ Margen de seguridad** | Despliegues son rápidos, deletéa al terminar |

#### 2️⃣ **Azure Functions - HTTP Trigger**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 - $0.10 USD** (plan de consumo) |
| **📊 Plan recomendado** | Consumption (pago por uso) |
| **✅ Gratuito** | **SÍ** - 1M invocaciones gratis/mes |
| **⏱️ Duración** | 15 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - Cobras solo por ejecuciones reales |
| **✨ Consejo** | Perfecto para principiantes, muy seguro |

---

### **NIVEL 300 - Intermedio**

#### 3️⃣ **MSAL.NET - Autenticación Interactiva**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 USD** |
| **📊 Servicios** | Solo registro en Azure AD (gratis) |
| **✅ Gratuito** | **SÍ** - 100% |
| **⏱️ Duración** | 15 minutos |
| **🔴 RIESGO SI LO DEJAS** | **NULO** - Sin recursos activos |
| **✨ Consejo** | Completamente seguro, solo código/autenticación |

#### 4️⃣ **API Management - Importar API**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.50 - $1.50 USD** |
| **📊 SKU recomendado** | Developer (sin SLA) ~$40/mes |
| **✅ Gratuito** | Primeras 24h en modo developer |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **MODERADO** - Instancia sigue corriendo |
| **✨ IMPORTANTE** | **Deletéa completamente al terminar** |

#### 5️⃣ **Application Insights - Auto-Instrumentación**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 - $0.50 USD** |
| **📊 Ingesta de datos** | Primeros 5 GB/mes gratis |
| **✅ Gratuito** | Parcialmente (datos limitados) |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - Ingesta de datos es lenta en laboratorios |
| **✨ Consejo** | No es peligroso; monitoreo es pasivo |

#### 6️⃣ **Container Registry - Compilar Imagen**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.30 - $0.80 USD** |
| **📊 SKU recomendado** | Basic (~$5/mes) |
| **✅ Gratuito** | Primeros 12 meses NO |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - Almacenamiento es la única tarifa |
| **✨ Consejo** | Deleteá la imagen/registry al terminar |

#### 7️⃣ **Container Instances - Ejecutar Contenedor**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.50 - $1.50 USD** |
| **📊 Compute** | Primeros 100 segundos gratis/mes |
| **✅ Gratuito** | Parcialmente (muy limitado) |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **ALTO** ⚠️ - Si olvidas el contenedor, sigue corriendo |
| **✨ CRITICAL** | **Deletéa el contenedor AL TERMINAR** |

#### 8️⃣ **Event Grid - Enrutar Eventos**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 - $0.20 USD** |
| **📊 Eventos** | Primeros 100,000 operaciones gratis/mes |
| **✅ Gratuito** | **SÍ** - Muy amigable con presupuesto |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - No consume si no hay eventos |
| **✨ Consejo** | Bastante seguro; buenos márgenes |

#### 9️⃣ **App Service - Deployment Slots**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.50 - $2 USD** |
| **📊 Plan recomendado** | Standard (mínimo para slots) ~$73/mes |
| **✅ Gratuito** | NO - Slots requieren plan Standard+ |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **MODERADO-ALTO** ⚠️ - Se cobra por slot activo |
| **✨ IMPORTANTE** | **Deleteá los slots y app service** |

---

### **NIVEL 400 - Avanzado**

#### 🔟 **Blob Storage - Operaciones de Almacenamiento**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.10 - $0.50 USD** |
| **📊 Almacenamiento** | $0.0208/GB primeros 250 TB |
| **✅ Gratuito** | Primeros 5 GB si es en Free tier |
| **⏱️ Duración** | 30 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO-MODERADO** - Cobras por almacenamiento, no por inactividad |
| **✨ Consejo** | Limpia los blobs/contenedores al terminar |

#### 1️⃣1️⃣ **Microsoft Graph - User Profile**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 USD** |
| **📊 API** | Llamadas API gratis |
| **✅ Gratuito** | **SÍ** - 100% (solo SDK) |
| **⏱️ Duración** | 15 minutos |
| **🔴 RIESGO SI LO DEJAS** | **NULO** - Sin recursos activos |
| **✨ Consejo** | Completamente seguro |

#### 1️⃣2️⃣ **Cosmos DB - Crear Database**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$2 - $8 USD** ⚠️ |
| **📊 Throughput** | Mínimo 400 RU/s (Serverless más barato) |
| **✅ Gratuito** | Primeros 12 meses NO |
| **⏱️ Duración** | 30 minutos |
| **🔴 RIESGO SI LO DEJAS** | **🔴 MÁXIMO RIESGO** ⚠️⚠️⚠️ |
| **💥 SI LO DEJAS CORRIENDO** | **$1-2 POR HORA** |
| **✨ CRÍTICO** | **Deletéa la cuenta de Cosmos DB INMEDIATAMENTE** |

#### 1️⃣3️⃣ **Key Vault - Almacenar Secretos**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.10 - $0.50 USD** |
| **📊 Operaciones** | Primeras 10,000 ops/mes gratis |
| **✅ Gratuito** | **SÍ** - Muy amigable |
| **⏱️ Duración** | 30 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - No consume si no accedes |
| **✨ Consejo** | Seguro; no necesita limpieza urgente |

#### 1️⃣4️⃣ **App Configuration - Recuperar Valores**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0 - $0.20 USD** |
| **📊 SKU** | Free para laboratorios |
| **✅ Gratuito** | **SÍ** - Free tier |
| **⏱️ Duración** | 15 minutos |
| **🔴 RIESGO SI LO DEJAS** | **NULO** - No consume |
| **✨ Consejo** | Completamente seguro |

#### 1️⃣5️⃣ **Event Hubs - Enviar/Recibir Eventos**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$1 - $4 USD** ⚠️ |
| **📊 SKU** | Standard es más barato que Premium (~$25/mes) |
| **✅ Gratuito** | NO - Cobros por throughput |
| **⏱️ Duración** | 30 minutos |
| **🔴 RIESGO SI LO DEJAS** | **MODERADO-ALTO** ⚠️ - Instancia reservada cuesta |
| **✨ IMPORTANTE** | **Deletéa namespace de Event Hubs** |

#### 1️⃣6️⃣ **Container Apps - Desplegar Contenedor**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.75 - $3 USD** ⚠️ |
| **📊 Compute** | $0.00005/vCPU-segundo + almacenamiento |
| **✅ Gratuito** | NO |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **ALTO** ⚠️ - Si la app corre, pagas |
| **✨ IMPORTANTE** | **Deletéa la Container App AL TERMINAR** |

---

### **NIVEL 500 - Experto**

#### 1️⃣7️⃣ **Service Bus - Enviar/Recibir Mensajes**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$2 - $6 USD** ⚠️ |
| **📊 SKU** | Standard (~$12.50/mes) |
| **✅ Gratuito** | NO - Cobros por operaciones |
| **⏱️ Duración** | 30 minutos |
| **🔴 RIESGO SI LO DEJAS** | **MODERADO** ⚠️ - No corre indefinidamente |
| **✨ IMPORTANTE** | **Deletéa el namespace al terminar** |

#### 1️⃣8️⃣ **Queue Storage - Mensajes en Cola**
| Aspecto | Detalle |
|--------|---------|
| **💰 Costo estimado** | **$0.20 - $0.80 USD** |
| **📊 Operaciones** | $0.40 por millón de transacciones |
| **✅ Gratuito** | Parcialmente (5 GB almacenamiento en free tier) |
| **⏱️ Duración** | 20 minutos |
| **🔴 RIESGO SI LO DEJAS** | **BAJO** - Solo cobras por almacenamiento, no por inactividad |
| **✨ Consejo** | Limpia las colas al terminar |

---

## 📊 RESUMEN FINANCIERO

| Nivel | Total Estimado | Máximo Riesgo |
|-------|---------------|--------------|
| **200** | **$0.50 - $2** | 🟡 Moderado (App Service) |
| **300** | **$1.50 - $5** | 🔴 Alto (API Mgmt, Container Instances) |
| **400** | **$4 - $20** | 🔴🔴 CRÍTICO (Cosmos DB) |
| **500** | **$2 - $8** | 🟡 Moderado (Service Bus) |
| **TOTAL** | **~$8 - $35 USD** | 🔴 COSMOS DB ES EL VILLANO |

---

## ⚡ CHECKLIST DE SEGURIDAD (HAZLO AL TERMINAR CADA LAB)

```
☐ Cosmos DB → DELETÉA TODA LA CUENTA
☐ Event Hubs → DELETÉA NAMESPACE
☐ Service Bus → DELETÉA NAMESPACE  
☐ API Management → DELETÉA INSTANCIA
☐ Container Apps → DELETÉA APLICACIÓN
☐ Container Instances → DELETÉA CONTENEDOR
☐ App Service → DELETÉA PLAN + APP
☐ Container Registry → DELETÉA IMÁGENES + REGISTRY
☐ Blob Storage → VACIÁ CONTENEDORES
☐ Application Insights → Opcional (es barato)
```

---

## 🎯 RECOMENDACIÓN DE ORDEN PARA MINIMIZAR COSTOS

1. **Empieza con NIVEL 200** (muy barato, máx $2)
2. **Después NIVEL 300** (moderado, pero limpia bien)
3. **Salta Cosmos DB primero en Nivel 400** (el más caro)
4. **Después Event Hubs en Nivel 400** (segundo más caro)
5. **El resto del Nivel 400 es seguro**
6. **Nivel 500 es moderado, sin grandes riesgos**

---

## 💡 TIPS PARA AHORRAR

- ✅ Usa **Free tier** cuando sea posible
- ✅ Deletéa SIEMPRE los recursos después de terminar
- ✅ No dejes máquinas/contenedores "corriendo"
- ✅ Usa **Consumption Plans** (pago por uso) vs planes fijos
- ✅ Monitorea el Portal de Azure cada día durante la primera semana
- ✅ Configura **alertas de presupuesto** (recomendado: $20)

¿Preguntas sobre algún laboratorio específico o necesitas ayuda para decidir por dónde empezar?