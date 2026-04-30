import paho.mqtt.client as mqtt
import json
import random
import time

broker = "localhost"
porta = 1883
topico = "industriais/sensores/4471"

cliente = mqtt.Client()
cliente.connect(broker, porta, 60)

print("Enviando dados para: ", broker)

try:
    while True:
        temperatura = random.randint(20, 90)
        umidade =  random.randint(30, 95)
        pressao = (random.random()) * 10
        vibracao = (random.random()) * 25
        nivel = random.randint(0, 100)

        dados = {
            "temperatura": temperatura,
            "umidade": umidade,
            "pressao": format(pressao, ".2f"),
            "vibracao": format(vibracao, ".2f"),
            "nivel": nivel
        }

        mensagem = json.dumps(dados)
        cliente.publish(topico, mensagem)
        time.sleep(2)

except KeyboardInterrupt:

    print("Programa encerrado")
    cliente.disconnect()