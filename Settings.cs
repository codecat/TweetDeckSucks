using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TweetdeckSucks
{
  public class Settings
  {
    private readonly string filename;

    private Dictionary<string, string> keys;

    public Settings(String filename)
    {
      this.filename = filename;

      this.Load();
    }

    private void Load()
    {
      if (File.Exists(this.filename)) {
        this.keys = File.ReadLines(this.filename)
                        .Select(s => s.Split(new[] {'='}, 2))
                        .Where(strings => strings.Length == 2)
                        .ToDictionary(strings => strings[0], strings => strings[1]);
      }
    }

    public void Save()
    {
      File.WriteAllLines(this.filename, this.keys.Select(pair => string.Format("{0}={1}", pair.Key, pair.Value)));
    }

    public void Cancel()
    {
      this.Load();
    }

    public string GetFilename()
    {
      return this.filename;
    }

    public string GetString(string key)
    {
      return this.keys.ContainsKey(key) ? this.keys[key] : "";
    }

    public bool GetBool(string key)
    {
      try {
        if (this.keys.ContainsKey(key)) {
          return bool.Parse(this.keys[key]);
        }
      } catch {}
      return false;
    }

    public int GetInt(string key)
    {
      try {
        if (this.keys.ContainsKey(key)) {
          return int.Parse(this.keys[key]);
        }
      } catch {}
      return 0;
    }

    public float GetFloat(string key)
    {
      try {
        if (this.keys.ContainsKey(key)) {
          return float.Parse(this.keys[key], CultureInfo.InvariantCulture.NumberFormat);
        }
      } catch {}
      return 0f;
    }

    public bool Contains(string key)
    {
      return this.keys.ContainsKey(key);
    }

    public void SetString(string key, string value)
    {
      this.keys[key] = value;
    }

    public void SetBool(string key, bool value)
    {
      this.keys[key] = value.ToString();
    }

    public void SetInt(string key, int value)
    {
      this.keys[key] = value.ToString(CultureInfo.InvariantCulture);
    }

    public void SetFloat(string key, float value)
    {
      this.keys[key] = value.ToString(CultureInfo.InvariantCulture);
    }

    public void Delete(string key)
    {
      if (this.keys.ContainsKey(key)) {
        this.keys.Remove(key);
      }
    }
  }
}