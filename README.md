Intended to greatly simplify configuration management for simple applications by providing a one line method to load configurations. It simply serializes and deserializes classes to/from disk as json, turning any class into a disk backed singleton. If the file does not exist, it is created using a default instance of the object. 

Additional information will be provided on full release