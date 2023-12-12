
# Hyper Company Proje Dökümanı

- Case'de detay verilmediği için ORM aracı olarak `Dapper`, veri tabanı olarak `MSSQL` kullanılmıştır.
- Proje çalışmadan önce `appsettings.json`'da bulunan `ConnectionString` bilgilerinin kontrol edilip ona göre projenin çalıştırılması önerilir.
- Proje ilk çalıştığında auto migration işlemi yapılacak ve ilgili tablolar doldurulacaktır.


## Kullanılan Teknolojiler

**Server :** Newtonsoft.Json, EntityFrameworkCore, DependencyInjection, Dapper

  
## API Kullanımı

#### Tüm renkleri getir

```http
  GET /api/color/all
```

#### Tekneleri Renk Id'ye göre getirir

```http
  GET /api/Boat/boats-by-colorId?colorId={}
```

#### Otobüsleri Renk Id'ye göre getirir

```http
  GET /api/Bus/bus-by-colorId?colorId={}
```

#### Arabaları Renk Id'ye göre getirir

```http
  GET /api/Car/car-by-colorId?colorId={}
```

#### Tüm araçları getirir

```http
  GET /api/Car/all-car
```

#### *********************


```http
  PUT /api/Car/toggle-headligths?headLigth
```
| Parametre | Tip     | Açıklama                       |
| :-------- | :------- | :-------------------------------- |
| `carId`      | `integer` | (**Zorunlu**) Araç Id'si |
| `headLigth`      | `boolean` | (**Zorunlu**) True = Araç farını açar. False = Araç farını kapatır. |

```http
  DELETE /api/Car/delete-car-by-id={}
```
| Parametre | Tip     | Açıklama                       |
| :-------- | :------- | :-------------------------------- |
| `carId`      | `integer` | **Zorunlu**. Araç Id'si |

  
## Destek

Destek için omerfaruqylmz@gmail.com adresine e-posta gönderin.

  
