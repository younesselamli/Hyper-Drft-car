import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

# Load the MNIST dataset
(x_train, y_train), (x_test, y_test) = tf.keras.datasets.mnist.load_data()

# Normalize the data
x_train = (x_train / 255.0 - 0.5) * 2
x_test = (x_test / 255.0 - 0.5) * 2

# Flatten the data
x_train = x_train.reshape(60000, 784)
x_test = x_test.reshape(10000, 784)

# Build the model
model = tf.keras.models.Sequential([
  tf.keras.layers.Dense(256, input_dim=784, activation=tf.nn.leaky_relu),
  tf.keras.layers.Dense(256, activation=tf.nn.leaky_relu),
  tf.keras.layers.Dense(256, activation=tf.nn.leaky_relu),
  tf.keras.layers.Dense(10, activation=tf.nn.softmax)
])

# Compile the model
model.compile(optimizer=tf.keras.optimizers.Adam(0.001),
              loss=tf.keras.losses.CategoricalCrossentropy(),
              metrics=['accuracy'])

# Train the model
model.fit(x_train, y_train, epochs=5, validation_data=(x_test, y_test))

# Generate some random noise
noise = np.random.uniform(-1, 1, size=(1, 784))

# Use the model to generate an image
generated_image = model.predict(noise)
generated_image = np.argmax(generated_image, axis=1)
generated_image = generated_image.reshape(28, 28)

# Show the generated image
plt.imshow(generated_image, cmap='gray')
plt.show()
