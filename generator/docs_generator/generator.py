import os
import yaml

SOURCE_DIR = "../../api"
DEST_DIR = "../../docs"

os.makedirs(DEST_DIR, exist_ok=True)

def extract_metadata(yaml_data):
    """Extract front-matter metadata from DocFX ApiPage YAML."""
    title = yaml_data.get('title', '')
    words = title.split()
    if not words:
        return {}
    metadata = {
        'title': words[-1],
    }
    return metadata

def convert_to_path(s):
    if s.lower().endswith(".html"):
        s = s[10:]
        s = s[:-5]
    path = "/".join(s.split(".")).lower()
    return path

def generate_markdown(yaml_data):
    """Generate Markdown content from DocFX ApiPage YAML."""
    md = ""
    for item in yaml_data.get('body', []):
        if 'h2' in item:
            md += f"## {item['h2']}\n\n"
        if 'h4' in item:
            md += f"#### {item['h4']}\n\n"
        if 'code' in item:
            md += "```csharp\n" + item['code'] + "\n```\n\n"
        if 'parameters' in item:
            for param in item['parameters']:
                param_name = param.get('name', '')
                param_type = ''
                if 'type' in param:
                    param_description = param.get('description', '')
                    parts = []
                    for t in param['type']:
                        if isinstance(t, dict):
                            url = t.get('url', '')
                            if url.endswith('.html'):
                                url = "/docs/api/" + convert_to_path(url)
                            parts.append(f"[{t['text']}]({url})")
                        else:
                            if str(t) == "text":
                                parts.append(f"[{param['type']['text']}]")
                            elif str(t) == "url":
                                url = param['type']['url']
                                if url.endswith('.html'):
                                    url = "/docs/api/" + convert_to_path(url)
                                parts.append(f"({url})")
                            else:
                                parts.append(str(t))

                    if param_description != '':
                        parts.append(f" - {param_description}")
                    param_type = ''.join(parts)
                md += f"- **{param_name}**: {param_type}\n" if param_name else f"- {param_type}\n"
            md += "\n"
        if 'api3' in item:
            src = item.get('src', '')
            md += f"**{item['api3']}**"
            if src != '':
                md += f" - [Source Code]({src})\n\n"
            else:
                md += "\n\n"
    return md

def convert_yaml_file(src_path, dest_path):
    with open(src_path, 'r', encoding='utf-8') as f:
        yaml_data = yaml.safe_load(f)

    if isinstance(yaml_data, list):
        yaml_data = yaml_data[0]

    metadata = extract_metadata(yaml_data)
    if metadata == {}:
        return
    
    md_content = "---\n"
    md_content += yaml.safe_dump(metadata, sort_keys=False)
    md_content += "---\n\n"
    md_content += generate_markdown(yaml_data)

    folder_path, file_name = os.path.split(dest_path)
    base_name, ext = os.path.splitext(file_name)
    final_path = dest_path

    if os.path.isdir(dest_path) or os.path.exists(os.path.join(folder_path, base_name)):
        final_folder = os.path.join(folder_path, base_name)
        os.makedirs(final_folder, exist_ok=True)
        final_path = os.path.join(final_folder, "index.md")
    else:
        os.makedirs(folder_path, exist_ok=True)

    with open(final_path, 'w', encoding='utf-8') as f:
        f.write(md_content)

for root, dirs, files in os.walk(SOURCE_DIR):
    for file in files:
        if file.endswith(".yml") or file.endswith(".yaml"):
            rel_path = os.path.relpath(root, SOURCE_DIR)
            dest_folder = os.path.join(DEST_DIR, rel_path)
            dest_file = os.path.join(dest_folder, convert_to_path(os.path.splitext(file)[0]) + ".md")
            convert_yaml_file(os.path.join(root, file), dest_file)

print("Markdown generation complete!")
